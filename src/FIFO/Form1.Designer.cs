namespace Algoritmos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.msgErro = new System.Windows.Forms.Label();
            this.nProcesso = new System.Windows.Forms.NumericUpDown();
            this.nTempo = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtProcesso = new System.Windows.Forms.DataGridView();
            this.btnVisualizarGantt = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgGrafico = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lQuantum = new System.Windows.Forms.Label();
            this.nQuantum = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempoProcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Processando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nProcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTempo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQuantum)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(143, 25);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(116, 23);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mensagem de erro";
            // 
            // msgErro
            // 
            this.msgErro.AutoSize = true;
            this.msgErro.Location = new System.Drawing.Point(12, 35);
            this.msgErro.Name = "msgErro";
            this.msgErro.Size = new System.Drawing.Size(0, 13);
            this.msgErro.TabIndex = 2;
            // 
            // nProcesso
            // 
            this.nProcesso.Enabled = false;
            this.nProcesso.Location = new System.Drawing.Point(13, 25);
            this.nProcesso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nProcesso.Name = "nProcesso";
            this.nProcesso.Size = new System.Drawing.Size(57, 20);
            this.nProcesso.TabIndex = 3;
            this.nProcesso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nTempo
            // 
            this.nTempo.Location = new System.Drawing.Point(76, 25);
            this.nTempo.Maximum = new decimal(new int[] {
            87,
            0,
            0,
            0});
            this.nTempo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTempo.Name = "nTempo";
            this.nTempo.Size = new System.Drawing.Size(61, 20);
            this.nTempo.TabIndex = 4;
            this.nTempo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.msgErro);
            this.panel1.Location = new System.Drawing.Point(14, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 118);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Processo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tempo";
            // 
            // dtProcesso
            // 
            this.dtProcesso.AllowUserToAddRows = false;
            this.dtProcesso.AllowUserToDeleteRows = false;
            this.dtProcesso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProcesso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.TempoProcesso,
            this.Processando});
            this.dtProcesso.Location = new System.Drawing.Point(14, 74);
            this.dtProcesso.Name = "dtProcesso";
            this.dtProcesso.ReadOnly = true;
            this.dtProcesso.Size = new System.Drawing.Size(245, 247);
            this.dtProcesso.TabIndex = 8;
            // 
            // btnVisualizarGantt
            // 
            this.btnVisualizarGantt.Location = new System.Drawing.Point(264, 22);
            this.btnVisualizarGantt.Name = "btnVisualizarGantt";
            this.btnVisualizarGantt.Size = new System.Drawing.Size(474, 23);
            this.btnVisualizarGantt.TabIndex = 9;
            this.btnVisualizarGantt.Text = "Visualizar";
            this.btnVisualizarGantt.UseVisualStyleBackColor = true;
            this.btnVisualizarGantt.Visible = false;
            this.btnVisualizarGantt.Click += new System.EventHandler(this.Button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "FIFO",
            "SJF",
            "RRobin"});
            this.comboBox1.Location = new System.Drawing.Point(3, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // dgGrafico
            // 
            this.dgGrafico.AllowUserToAddRows = false;
            this.dgGrafico.AllowUserToDeleteRows = false;
            this.dgGrafico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGrafico.Location = new System.Drawing.Point(5, 74);
            this.dgGrafico.Name = "dgGrafico";
            this.dgGrafico.ReadOnly = true;
            this.dgGrafico.Size = new System.Drawing.Size(733, 371);
            this.dgGrafico.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Algoritmo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lQuantum
            // 
            this.lQuantum.AutoSize = true;
            this.lQuantum.Location = new System.Drawing.Point(126, 7);
            this.lQuantum.Name = "lQuantum";
            this.lQuantum.Size = new System.Drawing.Size(50, 13);
            this.lQuantum.TabIndex = 14;
            this.lQuantum.Text = "Quantum";
            this.lQuantum.Visible = false;
            // 
            // nQuantum
            // 
            this.nQuantum.Location = new System.Drawing.Point(131, 25);
            this.nQuantum.Maximum = new decimal(new int[] {
            87,
            0,
            0,
            0});
            this.nQuantum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nQuantum.Name = "nQuantum";
            this.nQuantum.Size = new System.Drawing.Size(127, 20);
            this.nQuantum.TabIndex = 13;
            this.nQuantum.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nQuantum.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgGrafico);
            this.panel2.Controls.Add(this.btnVisualizarGantt);
            this.panel2.Controls.Add(this.lQuantum);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.nQuantum);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(295, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 460);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.dtProcesso);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btnAdicionar);
            this.panel3.Controls.Add(this.nProcesso);
            this.panel3.Controls.Add(this.nTempo);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 460);
            this.panel3.TabIndex = 16;
            // 
            // Numero
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Numero.DefaultCellStyle = dataGridViewCellStyle1;
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 50;
            // 
            // TempoProcesso
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.TempoProcesso.DefaultCellStyle = dataGridViewCellStyle2;
            this.TempoProcesso.HeaderText = "Tempo";
            this.TempoProcesso.Name = "TempoProcesso";
            this.TempoProcesso.ReadOnly = true;
            this.TempoProcesso.Width = 50;
            // 
            // Processando
            // 
            this.Processando.HeaderText = "Processando";
            this.Processando.Name = "Processando";
            this.Processando.ReadOnly = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(14, 51);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(245, 20);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Limpar processos";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1060, 483);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nProcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTempo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQuantum)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Processo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracao;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label msgErro;
        private System.Windows.Forms.NumericUpDown nProcesso;
        private System.Windows.Forms.NumericUpDown nTempo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtProcesso;
        private System.Windows.Forms.Button btnVisualizarGantt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgGrafico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lQuantum;
        private System.Windows.Forms.NumericUpDown nQuantum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempoProcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Processando;
        private System.Windows.Forms.Button btnClear;
    }
}

