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
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.msgErro = new System.Windows.Forms.Label();
            this.nProcesso = new System.Windows.Forms.NumericUpDown();
            this.nTempo = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtProcesso = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempoProcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgGrafico = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nProcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTempo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Adicionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
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
            this.nProcesso.Location = new System.Drawing.Point(11, 22);
            this.nProcesso.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nProcesso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nProcesso.Name = "nProcesso";
            this.nProcesso.Size = new System.Drawing.Size(113, 20);
            this.nProcesso.TabIndex = 3;
            this.nProcesso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nTempo
            // 
            this.nTempo.Location = new System.Drawing.Point(130, 22);
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
            this.nTempo.Size = new System.Drawing.Size(127, 20);
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
            this.panel1.Location = new System.Drawing.Point(515, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 42);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Processo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 2);
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
            this.TempoProcesso});
            this.dtProcesso.Location = new System.Drawing.Point(12, 70);
            this.dtProcesso.Name = "dtProcesso";
            this.dtProcesso.ReadOnly = true;
            this.dtProcesso.Size = new System.Drawing.Size(245, 247);
            this.dtProcesso.TabIndex = 8;
            // 
            // Numero
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Numero.DefaultCellStyle = dataGridViewCellStyle1;
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // TempoProcesso
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.TempoProcesso.DefaultCellStyle = dataGridViewCellStyle2;
            this.TempoProcesso.HeaderText = "Tempo";
            this.TempoProcesso.Name = "TempoProcesso";
            this.TempoProcesso.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(266, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(613, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Visualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "FIFO",
            "SJF"});
            this.comboBox1.Location = new System.Drawing.Point(263, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // dgGrafico
            // 
            this.dgGrafico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGrafico.Location = new System.Drawing.Point(266, 85);
            this.dgGrafico.Name = "dgGrafico";
            this.dgGrafico.Size = new System.Drawing.Size(611, 232);
            this.dgGrafico.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Algoritmo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(893, 358);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgGrafico);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dtProcesso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nTempo);
            this.Controls.Add(this.nProcesso);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nProcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTempo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label msgErro;
        private System.Windows.Forms.NumericUpDown nProcesso;
        private System.Windows.Forms.NumericUpDown nTempo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtProcesso;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempoProcesso;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgGrafico;
        private System.Windows.Forms.Label label6;
    }
}

