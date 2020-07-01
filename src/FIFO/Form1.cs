using Algoritmos.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos
{
    public partial class Form1 : Form
    {
        private readonly IAlgoritmoContext contexto;
        private readonly IAlgoritmoContext contextFIFO;
        private int flagControle = 0;
        private int inicioProcesso = 0;
        private int fimProcesso = 0;

        public Form1()
        {
            InitializeComponent();
            contexto = new AlgoritmoContext();
            contextFIFO = new AlgoritmoFIFO();
            dtProcesso.DataSource = null;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //TODO : ATÉ 10 PROCESSOS
            //TODO : TEMPO 80
            //FIFO : O PROCESSO É O QUE VAI RODA PRIMEIRO 

            
            var maxTempo = nTempo.Maximum;
            var numeroProcesso = nProcesso.Value;
            var tempoProcesso = nTempo.Value;
                       
            nTempo.Maximum = maxTempo - tempoProcesso;
                    

            if (flagControle == 0) {

                fimProcesso = (int)tempoProcesso;
                CriarProcesso(
                (int)numeroProcesso,
                (int)tempoProcesso,
                inicioProcesso,
                fimProcesso);
                flagControle++;
            }
            else {

                inicioProcesso = fimProcesso;
                fimProcesso = fimProcesso+(int)tempoProcesso;
                CriarProcesso(
                (int)numeroProcesso,
                (int)tempoProcesso,
                inicioProcesso,
                fimProcesso);
            }

            nProcesso.Value++;
            var maxProcesso = contexto.BuscarProcessos().Count();
            if (maxProcesso == 10)
            {
                btnAdicionar.Enabled = false;
            }
        }

        private void CriarProcesso(
            int numeroProcesso, 
            int tempoProcesso,
            int inicioProcesso,
            int fimProcesso)
        {
           
            var processo = new Algoritmo(numeroProcesso, 
                                         tempoProcesso, 
                                         inicioProcesso,
                                         fimProcesso);

            if (!processo.EhValido())
            {
                msgErro.Text = processo.ToString();
                return;
            }
                
            contexto.AdicionarProcesso(processo);

            dtProcesso.AutoGenerateColumns = false;           
            int rowId = dtProcesso.Rows.Add();
            DataGridViewRow row = dtProcesso.Rows[rowId];
            row.Cells[0].Value = numeroProcesso;
            row.Cells[1].Value = tempoProcesso;          

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

            GerarGraficoDeProcesso();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void GerarGraficoDeProcesso()
        {
            var algoritmo = comboBox1.SelectedItem;

            switch (algoritmo)
            {
                case "FIFO":
                    ProcessarFIFO();
                    break;
                case "SJF":
                    ProcessarSJF();
                    break;
                case "RRobin":
                    ProcessarRRobin();
                    break;
                default:                    
                    break;
            }
        }

        private void ProcessarRRobin()
        {
            //TODO IMPLEMTAR LOGICA 
            var quantum = (int)nQuantum.Value;
            //TODO : Tenho uma lista
            //cada elemento da minha lista tem um tempo
            //vou percorer o primeiro item da minha lista
            //se o tempo for maior que o meu quantum eu subtraio o meu tempo do meu quantum e a difenrenca fica para um proximo procesamento

            //TODO : IMPLEMTAR LOGICA
            var novaLista = new List<Algoritmo>();

            ResetDataGridGraficoView();

            var listaProcesso = contexto.BuscarProcessos().ToArray();
            var listaRRobin = new List<Algoritmo>();
            var listaSobra = new List<Algoritmo>();
            var listaTeste = new List<Algoritmo>();
            flagControle = 0;
            inicioProcesso = 0;
            fimProcesso = 0;

            var totalProcesso = listaProcesso.Count();
            var controle = true;
            do
            {

                if (listaSobra.Count == 0) {
                    foreach (var item in listaProcesso)
                    {
                        if (item.TempoProcesso <= quantum)
                        {
                            listaRRobin.Add(item);
                        }
                        else
                        {

                            var novoProcesso = new Algoritmo(item.Numero,
                                                             quantum,
                                                             item.InicioProcesso,
                                                             item.FimProcesso);
                            listaRRobin.Add(novoProcesso);

                            var tempoNovo = item.TempoProcesso - quantum;
                            var SobraProcesso = new Algoritmo(item.Numero,
                                                               tempoNovo,
                                                               item.InicioProcesso,
                                                               item.FimProcesso);

                            listaSobra.Add(SobraProcesso);
                        }
                    }
                }
               

                if (listaSobra.Count > 0)
                {
                    for (int i = 0; i < listaSobra.Count; i++)
                    {
                        if (listaSobra[i].TempoProcesso <= quantum)
                        {
                            var novoProcesso = new Algoritmo(listaSobra[i].Numero,
                                                            listaSobra[i].TempoProcesso,
                                                            listaSobra[i].InicioProcesso,
                                                            listaSobra[i].FimProcesso);

                            listaTeste.Add(novoProcesso);
                            listaSobra.RemoveAt(i);
                        }
                        else
                        {

                            var novoProcesso = new Algoritmo(listaSobra[i].Numero,
                                                             quantum,
                                                             listaSobra[i].InicioProcesso,
                                                             listaSobra[i].FimProcesso);
                            listaTeste.Add(novoProcesso);


                            var tempoNovo = listaSobra[i].TempoProcesso - quantum;
                            var SobraProcesso = new Algoritmo(listaSobra[i].Numero,
                                                               tempoNovo,
                                                               listaSobra[i].InicioProcesso,
                                                               listaSobra[i].FimProcesso);
                            listaSobra.RemoveAt(i);
                            listaSobra.Add(SobraProcesso);
                        }
                    }
                  
                }
                if(listaSobra.Count()==0)
                {
                    controle = false;
                }
                  

            } while (controle);

            var newInicio = 0;
            var newFim = 0;
            foreach (var item in listaTeste)
            {
                if (newInicio == 0)
                {
                    newFim = item.TempoProcesso + newInicio;
                    item.InicioProcesso = newInicio;
                    item.FimProcesso = newFim;
                    newInicio = item.TempoProcesso;
                }
                else
                {
                    newInicio = newFim;
                    newFim = item.TempoProcesso + newInicio;

                    item.InicioProcesso = newInicio;
                    item.FimProcesso = newFim;
                }

            }

            newInicio = 0;
            newFim = 0;

            foreach (var item in listaRRobin)
            {
                if (newInicio == 0)
                {
                    newFim = item.TempoProcesso + newInicio;
                    item.InicioProcesso = newInicio;
                    item.FimProcesso = newFim;
                    newInicio = item.TempoProcesso;
                }
                else
                {
                    newInicio = newFim;
                    newFim = item.TempoProcesso + newInicio;

                    item.InicioProcesso = newInicio;
                    item.FimProcesso = newFim;
                }

            }

            listaRRobin.AddRange(listaTeste);
            var totalDetempo = listaRRobin.Sum(processos => processos.TempoProcesso);
            var totalDeProcesso = listaRRobin.Count();
            CriarDataGridView(totalDetempo, totalDeProcesso);
            DesenharDataGridViewAsync(listaRRobin, totalDetempo, totalDeProcesso);
        }

        private void ProcessarSJF()
        {
            //TODO : IMPLEMTAR LOGICA
            ResetDataGridGraficoView();


            //TODO : Organiza processo
            var listaProcesso = new List<Algoritmo>();
            flagControle = 0;
            inicioProcesso = 0;
            fimProcesso = 0;
            var listaOrdenada = contexto.BuscarProcessos().OrderBy(c => c.TempoProcesso).ToList();
          
            foreach (var item in listaOrdenada)
            {
               
                if (flagControle == 0)
                {
                    inicioProcesso = flagControle;
                    fimProcesso = item.TempoProcesso;
                    var processo = new Algoritmo(item.Numero,
                                          item.TempoProcesso,
                                          inicioProcesso,
                                          fimProcesso);

                    listaProcesso.Add(processo);
                    flagControle= item.TempoProcesso;
                }
                else {

                    inicioProcesso = flagControle;
                    fimProcesso = item.TempoProcesso+ inicioProcesso;
                    var processo = new Algoritmo(item.Numero,
                                         item.TempoProcesso,
                                         inicioProcesso,
                                         fimProcesso);

                    listaProcesso.Add(processo);
                    flagControle = fimProcesso;
                }
              
            }

            var totalDetempo = listaProcesso.Sum(processos => processos.TempoProcesso);
            var totalDeProcesso = listaProcesso.Count();

            CriarDataGridView(totalDetempo, totalDeProcesso);
            DesenharDataGridViewAsync(listaProcesso, totalDetempo, totalDeProcesso);
        }

        private void ProcessarFIFO()
        {
            //TODO : IMPLEMTAR LOGICA
            ResetDataGridGraficoView();

            var listaProcesso = contexto.BuscarProcessos();
            var totalDetempo = listaProcesso.Sum(processos => processos.TempoProcesso);
            var totalDeProcesso = listaProcesso.Count();

            CriarDataGridView(totalDetempo, totalDeProcesso);
            DesenharDataGridViewAsync(listaProcesso, totalDetempo, totalDeProcesso);
        }

        private async Task DesenharDataGridViewAsync(ICollection<Algoritmo> listaProcesso, int totalDetempo, int totalDeProcesso)
        {
            var contaGridProcesso = dtProcesso.RowCount;

            for (int rowIndex = 0; rowIndex < totalDeProcesso; rowIndex++)
            {
                var processo = listaProcesso.ElementAt<Algoritmo>(rowIndex);

                for (int Processo = 0; Processo < contaGridProcesso; Processo++)
                {
                    var numroProcessoExcucao = (int)dtProcesso.Rows[Processo].Cells[0].Value;
                    if (numroProcessoExcucao == processo.Numero)
                    {
                        var corProcessamento = dtProcesso.Rows[Processo].Cells[2].Style.BackColor;
                        if (corProcessamento == Color.LightGreen)
                        {
                            dtProcesso.Rows[Processo].Cells[2].Style.BackColor = Color.Yellow;
                        }                           
                        if(corProcessamento == Color.Yellow)
                        {
                            dtProcesso.Rows[Processo].Cells[2].Style.BackColor = Color.Red;
                        }
                        if(dtProcesso.Rows[Processo].Cells[2].Value != "YES")
                        {
                            dtProcesso.Rows[Processo].Cells[2].Value = "YES";
                            dtProcesso.Rows[Processo].Cells[2].Style.BackColor = Color.LightGreen;
                        }
                        
                    }
                }

                for (int columnIndex = 0; columnIndex < totalDetempo; columnIndex++)
                {
                    if (columnIndex >= processo.InicioProcesso && columnIndex < processo.FimProcesso)
                    {
                        dgGrafico.Rows[rowIndex].Cells[columnIndex].Value = "##";
                        dgGrafico.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.LightGreen;
                        await Task.Delay(2000);
                    }
                }
            }
        }

        private void CriarDataGridView(int totalDetempo, int totalDeProcesso)
        {
            for (int column = 0; column < totalDetempo; column++)
            {
                dgGrafico.Columns.Add($"t{column}", $"t{column}");
            }
            for (int rowIndex = 0; rowIndex < totalDeProcesso; rowIndex++)
            {
                dgGrafico.Rows.Add();
            }
        }

        private void ResetDataGridGraficoView()
        {
            var columnTotal = dgGrafico.Columns.Count;
            for (int column = 0; column < columnTotal; column++)
            {
                dgGrafico.Columns.RemoveAt(0);
            }

            var rowwTotal = dgGrafico.Rows.Count;
            for (int rowIndex = 0; rowIndex < rowwTotal; rowIndex++)
            {
                dgGrafico.Rows.RemoveAt(0);
            }
        }
        private void ResetDataGridProcessoView()
        {
          
            var rowwTotal = dtProcesso.Rows.Count;
            for (int rowIndex = 0; rowIndex < rowwTotal; rowIndex++)
            {
                dtProcesso.Rows.RemoveAt(0);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rrobin = (ComboBox)sender;
            if(rrobin.SelectedItem == "RRobin")
            {
                lQuantum.Visible = true;
                nQuantum.Visible = true;
            }
            if (rrobin.SelectedItem != "RRobin")
            {
                lQuantum.Visible = false;
                nQuantum.Visible = false;
            }

            btnVisualizarGantt.Visible = true;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ResetDataGridGraficoView();
            ResetDataGridProcessoView();
            nProcesso.Value = 1;
            lQuantum.Visible = false;
            nQuantum.Visible = false;
            btnVisualizarGantt.Visible = false;
            btnAdicionar.Enabled = true;
            contexto.LimparProcessos();
        }
    }
}

