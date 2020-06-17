using Algoritmos.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

            var maxProcesso = nProcesso.Maximum;
            var maxTempo = nTempo.Maximum;

            var numeroProcesso = nProcesso.Value;
            var tempoProcesso = nTempo.Value;

            nProcesso.Maximum = maxProcesso - numeroProcesso;
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
                default:                    
                    break;
            }
        }

        private void ProcessarSJF()
        {
            //TODO IMPLEMTAR LOGICA            
        }

        private void ProcessarFIFO()
        {
            //TODO : IMPLEMTAR LOGICA
            ResetDataGridView();

            var listaProcesso = contexto.BuscarProcessos();
            var totalDetempo = listaProcesso.Sum(processos => processos.TempoProcesso);
            var totalDeProcesso = listaProcesso.Count();

            CriarDataGridView(totalDetempo, totalDeProcesso);
            DesenharDataGridView(listaProcesso, totalDetempo, totalDeProcesso);
        }

        private void DesenharDataGridView(ICollection<Algoritmo> listaProcesso, int totalDetempo, int totalDeProcesso)
        {
            for (int rowIndex = 0; rowIndex < totalDeProcesso; rowIndex++)
            {
                var processo = listaProcesso.ElementAt<Algoritmo>(rowIndex);

                for (int columnIndex = 0; columnIndex < totalDetempo; columnIndex++)
                {
                    if (columnIndex >= processo.InicioProcesso && columnIndex < processo.FimProcosso)
                    {
                        dgGrafico.Rows[rowIndex].Cells[columnIndex].Value = "##";
                        dgGrafico.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.LightGreen;

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

        private void ResetDataGridView()
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
    }
}

