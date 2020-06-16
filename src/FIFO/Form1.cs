using Algoritmos.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Algoritmos
{
    public partial class Form1 : Form
    {
        private readonly IAlgoritmoContext contexto;
        public Form1()
        {
            InitializeComponent();
            contexto = new AlgoritmoContext();
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

            CriarProcesso((int)numeroProcesso, (int)tempoProcesso);       
        }

        private void CriarProcesso(int numeroProcesso, int tempoProcesso)
        {
            var processo = new Algoritmo(numeroProcesso, tempoProcesso);

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
            dgGrafico.AutoGenerateColumns = false;          

           
            var listaProcesso = contexto.BuscarProcessos();

            foreach (var item in listaProcesso)
            {
                             
            }
           //TODO IMPLEMTAR LOGICA
        }
    }
}

