using System;

namespace Timer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MinQuestao = new System.Windows.Forms.NumericUpDown();
            this.SegQuestao = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.QutQuestoes = new System.Windows.Forms.NumericUpDown();
            this.Iniciar = new System.Windows.Forms.Button();
            this.Pausar = new System.Windows.Forms.Button();
            this.Proxima = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Zerar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Naocons = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Ajuda = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trestante = new System.Windows.Forms.Label();
            this.ttotal = new System.Windows.Forms.Label();
            this.tmedio = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NaoResolvidas = new System.Windows.Forms.NumericUpDown();
            this.Resolvidas = new System.Windows.Forms.NumericUpDown();
            this.Tempo = new System.Windows.Forms.Timer(this.components);
            this.continuar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.TEMPOALFA = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MinQuestao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegQuestao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QutQuestoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NaoResolvidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resolvidas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Chicken Butt", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "VesTimer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("orange juice", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tempo Para";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("orange juice", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cada Questão:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("orange juice", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "(Min + Sec)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("orange juice", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(451, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantidade ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("orange juice", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(454, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "De Questões:";
            // 
            // MinQuestao
            // 
            this.MinQuestao.Font = new System.Drawing.Font("Limbus Cond Demo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinQuestao.Location = new System.Drawing.Point(228, 51);
            this.MinQuestao.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.MinQuestao.Name = "MinQuestao";
            this.MinQuestao.ReadOnly = true;
            this.MinQuestao.Size = new System.Drawing.Size(48, 28);
            this.MinQuestao.TabIndex = 1;
            this.MinQuestao.TabStop = false;
            this.MinQuestao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MinQuestao.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // SegQuestao
            // 
            this.SegQuestao.Font = new System.Drawing.Font("Limbus Cond Demo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SegQuestao.Location = new System.Drawing.Point(301, 51);
            this.SegQuestao.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.SegQuestao.Name = "SegQuestao";
            this.SegQuestao.ReadOnly = true;
            this.SegQuestao.Size = new System.Drawing.Size(48, 28);
            this.SegQuestao.TabIndex = 2;
            this.SegQuestao.TabStop = false;
            this.SegQuestao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("orange juice", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(274, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 39);
            this.label7.TabIndex = 9;
            this.label7.Text = "+";
            // 
            // QutQuestoes
            // 
            this.QutQuestoes.Font = new System.Drawing.Font("Limbus Cond Demo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QutQuestoes.Location = new System.Drawing.Point(604, 49);
            this.QutQuestoes.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.QutQuestoes.Name = "QutQuestoes";
            this.QutQuestoes.Size = new System.Drawing.Size(65, 28);
            this.QutQuestoes.TabIndex = 10;
            this.QutQuestoes.TabStop = false;
            this.QutQuestoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.QutQuestoes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Iniciar
            // 
            this.Iniciar.BackColor = System.Drawing.Color.White;
            this.Iniciar.CausesValidation = false;
            this.Iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Iniciar.Location = new System.Drawing.Point(147, 459);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(122, 46);
            this.Iniciar.TabIndex = 17;
            this.Iniciar.TabStop = false;
            this.Iniciar.Text = "Iniciar";
            this.Iniciar.UseVisualStyleBackColor = false;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // Pausar
            // 
            this.Pausar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Pausar.Location = new System.Drawing.Point(275, 459);
            this.Pausar.Name = "Pausar";
            this.Pausar.Size = new System.Drawing.Size(122, 46);
            this.Pausar.TabIndex = 18;
            this.Pausar.TabStop = false;
            this.Pausar.Text = "Pausar";
            this.Pausar.UseVisualStyleBackColor = false;
            this.Pausar.Click += new System.EventHandler(this.Pausar_Click);
            // 
            // Proxima
            // 
            this.Proxima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(253)))), ((int)(((byte)(169)))));
            this.Proxima.CausesValidation = false;
            this.Proxima.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Proxima.Location = new System.Drawing.Point(543, 433);
            this.Proxima.Name = "Proxima";
            this.Proxima.Size = new System.Drawing.Size(155, 46);
            this.Proxima.TabIndex = 19;
            this.Proxima.TabStop = false;
            this.Proxima.Text = "Próxima";
            this.Proxima.UseVisualStyleBackColor = false;
            this.Proxima.Click += new System.EventHandler(this.Proxima_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Timer.Properties.Resources.a1;
            this.pictureBox1.Location = new System.Drawing.Point(604, 402);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(647, 400);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 22);
            this.label12.TabIndex = 21;
            this.label12.Text = "(Espaço)";
            this.label12.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("orange juice", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(65, 60);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 29);
            this.label15.TabIndex = 28;
            this.label15.Text = "Resolvidas:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("orange juice", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(76, 36);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 29);
            this.label16.TabIndex = 27;
            this.label16.Text = "Questões";
            // 
            // Zerar
            // 
            this.Zerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Zerar.CausesValidation = false;
            this.Zerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Zerar.Font = new System.Drawing.Font("Limbus Cond Demo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zerar.Location = new System.Drawing.Point(-1, -1);
            this.Zerar.Name = "Zerar";
            this.Zerar.Size = new System.Drawing.Size(83, 28);
            this.Zerar.TabIndex = 30;
            this.Zerar.TabStop = false;
            this.Zerar.Text = "Zerar";
            this.Zerar.UseVisualStyleBackColor = false;
            this.Zerar.Click += new System.EventHandler(this.Zerar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("orange juice", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(453, 61);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 29);
            this.label17.TabIndex = 32;
            this.label17.Text = "Resolvidas:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("orange juice", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(441, 36);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(154, 29);
            this.label18.TabIndex = 31;
            this.label18.Text = "Questões NÃO";
            // 
            // Naocons
            // 
            this.Naocons.BackColor = System.Drawing.Color.Fuchsia;
            this.Naocons.CausesValidation = false;
            this.Naocons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Naocons.Font = new System.Drawing.Font("orange juice", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naocons.Location = new System.Drawing.Point(544, 480);
            this.Naocons.Name = "Naocons";
            this.Naocons.Size = new System.Drawing.Size(154, 46);
            this.Naocons.TabIndex = 34;
            this.Naocons.TabStop = false;
            this.Naocons.Text = "Não Consegui";
            this.Naocons.UseVisualStyleBackColor = false;
            this.Naocons.Click += new System.EventHandler(this.Naocons_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(724, 475);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 22);
            this.label19.TabIndex = 36;
            this.label19.Text = "(Esc)";
            this.label19.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Timer.Properties.Resources.a1;
            this.pictureBox4.Location = new System.Drawing.Point(681, 477);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(66, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // Ajuda
            // 
            this.Ajuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.Ajuda.CausesValidation = false;
            this.Ajuda.Cursor = System.Windows.Forms.Cursors.Help;
            this.Ajuda.Font = new System.Drawing.Font("Limbus Cond Demo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajuda.Location = new System.Drawing.Point(774, -1);
            this.Ajuda.Name = "Ajuda";
            this.Ajuda.Size = new System.Drawing.Size(83, 28);
            this.Ajuda.TabIndex = 37;
            this.Ajuda.TabStop = false;
            this.Ajuda.Text = "Ajuda";
            this.Ajuda.UseVisualStyleBackColor = false;
            this.Ajuda.Click += new System.EventHandler(this.Ajuda_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.QutQuestoes);
            this.groupBox1.Controls.Add(this.SegQuestao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MinQuestao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 122);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.trestante);
            this.groupBox2.Controls.Add(this.ttotal);
            this.groupBox2.Controls.Add(this.tmedio);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.NaoResolvidas);
            this.groupBox2.Controls.Add(this.Resolvidas);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(35, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(789, 239);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // trestante
            // 
            this.trestante.AutoSize = true;
            this.trestante.BackColor = System.Drawing.Color.Transparent;
            this.trestante.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trestante.ForeColor = System.Drawing.Color.DarkRed;
            this.trestante.Location = new System.Drawing.Point(22, 169);
            this.trestante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trestante.Name = "trestante";
            this.trestante.Size = new System.Drawing.Size(176, 37);
            this.trestante.TabIndex = 41;
            this.trestante.Text = "0Min 0Seg";
            // 
            // ttotal
            // 
            this.ttotal.AutoSize = true;
            this.ttotal.BackColor = System.Drawing.Color.Transparent;
            this.ttotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttotal.Location = new System.Drawing.Point(606, 155);
            this.ttotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ttotal.Name = "ttotal";
            this.ttotal.Size = new System.Drawing.Size(88, 19);
            this.ttotal.TabIndex = 43;
            this.ttotal.Text = "0Min 0Seg";
            // 
            // tmedio
            // 
            this.tmedio.AutoSize = true;
            this.tmedio.BackColor = System.Drawing.Color.Transparent;
            this.tmedio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmedio.Location = new System.Drawing.Point(422, 158);
            this.tmedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tmedio.Name = "tmedio";
            this.tmedio.Size = new System.Drawing.Size(88, 19);
            this.tmedio.TabIndex = 42;
            this.tmedio.Text = "0Min 0Seg";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("orange juice", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(56, 132);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 37);
            this.label11.TabIndex = 40;
            this.label11.Text = "TIMER:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("orange juice", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-28, 97);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(837, 29);
            this.label10.TabIndex = 37;
            this.label10.Text = "---------------------------------------------------------------------------------" +
    "----------------------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("orange juice", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(396, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 26);
            this.label9.TabIndex = 36;
            this.label9.Text = "Tempo Médio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("orange juice", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(587, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 26);
            this.label8.TabIndex = 35;
            this.label8.Text = "Tempo Total:";
            // 
            // NaoResolvidas
            // 
            this.NaoResolvidas.Font = new System.Drawing.Font("Limbus Cond Demo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NaoResolvidas.Location = new System.Drawing.Point(597, 49);
            this.NaoResolvidas.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NaoResolvidas.Name = "NaoResolvidas";
            this.NaoResolvidas.ReadOnly = true;
            this.NaoResolvidas.Size = new System.Drawing.Size(120, 28);
            this.NaoResolvidas.TabIndex = 34;
            this.NaoResolvidas.TabStop = false;
            this.NaoResolvidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NaoResolvidas.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // Resolvidas
            // 
            this.Resolvidas.Font = new System.Drawing.Font("Limbus Cond Demo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resolvidas.Location = new System.Drawing.Point(200, 49);
            this.Resolvidas.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Resolvidas.Name = "Resolvidas";
            this.Resolvidas.ReadOnly = true;
            this.Resolvidas.Size = new System.Drawing.Size(120, 28);
            this.Resolvidas.TabIndex = 33;
            this.Resolvidas.TabStop = false;
            this.Resolvidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Resolvidas.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // Tempo
            // 
            this.Tempo.Interval = 1000;
            this.Tempo.Tick += new System.EventHandler(this.Tempo_Tick);
            // 
            // continuar
            // 
            this.continuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.continuar.CausesValidation = false;
            this.continuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continuar.Enabled = false;
            this.continuar.Location = new System.Drawing.Point(275, 459);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(122, 46);
            this.continuar.TabIndex = 40;
            this.continuar.TabStop = false;
            this.continuar.Text = "Continuar";
            this.continuar.UseVisualStyleBackColor = false;
            this.continuar.Visible = false;
            this.continuar.Click += new System.EventHandler(this.continuar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.IndianRed;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Help;
            this.linkLabel1.Font = new System.Drawing.Font("This Font is Stressed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(0, 511);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(142, 26);
            this.linkLabel1.TabIndex = 41;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "by: Alexandre";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("orange juice", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(396, 178);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 26);
            this.label13.TabIndex = 44;
            this.label13.Text = "Tempo Máximo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(423, 206);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 19);
            this.label14.TabIndex = 45;
            this.label14.Text = "0Min 0Seg";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("orange juice", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(587, 178);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(144, 26);
            this.label20.TabIndex = 46;
            this.label20.Text = "Tempo EXTRA:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(617, 207);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 19);
            this.label21.TabIndex = 47;
            this.label21.Text = "0Min 0Seg";
            // 
            // TEMPOALFA
            // 
            this.TEMPOALFA.Interval = 1000;
            this.TEMPOALFA.Tick += new System.EventHandler(this.TEMPOALFA_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Timer.Properties.Resources.Gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 537);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.continuar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Ajuda);
            this.Controls.Add(this.Naocons);
            this.Controls.Add(this.Zerar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Proxima);
            this.Controls.Add(this.Pausar);
            this.Controls.Add(this.Iniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.pictureBox4);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("orange juice", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VestTimer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.MinQuestao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegQuestao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QutQuestoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NaoResolvidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resolvidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown MinQuestao;
        private System.Windows.Forms.NumericUpDown SegQuestao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown QutQuestoes;
        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.Button Pausar;
        private System.Windows.Forms.Button Proxima;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Zerar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button Naocons;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button Ajuda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown NaoResolvidas;
        private System.Windows.Forms.NumericUpDown Resolvidas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer Tempo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label trestante;
        private System.Windows.Forms.Label ttotal;
        private System.Windows.Forms.Label tmedio;
        private System.Windows.Forms.Button continuar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Timer TEMPOALFA;
    }
}

