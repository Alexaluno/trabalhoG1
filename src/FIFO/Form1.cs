using FIFO.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FIFO
{
    public partial class Form1 : Form
    {
        private readonly IFIFOContext contexto;
        public Form1()
        {
            InitializeComponent();
            contexto = new FIFOContext();
            
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
            var processo = new FIFO(numeroProcesso, tempoProcesso);

            if (!processo.EhValido())
            {
                msgErro.Text = processo.ToString();
                return;
            }
                

            contexto.AdicionarProcesso(processo);
   
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var lista = contexto.BuscarProcessos().ToList();
            dtProcesso.DataSource = null;

            BindingSource binding = new BindingSource();
            binding.DataSource = lista;

            dtProcesso.AutoGenerateColumns = false;
            dtProcesso.AutoSize = true;
            dtProcesso.DataSource = binding;

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

        private static void ProcessarFIFO()
        {
           //TODO IMPLEMTAR LOGICA
        }
    }
}

