namespace Mouse3D
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.lbD = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.lbE = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbF = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sobe = new System.Windows.Forms.TabPage();
            this.direita = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rotacao = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Stz = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Stx = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Dtz = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Dtx = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lbConectado = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.sobe.SuspendLayout();
            this.direita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.rotacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 443);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(740, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(852, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sobe (A):";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(924, 66);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mouse 3D";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desce (B):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Esquerda (C):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Direita (D):";
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(586, 61);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(26, 29);
            this.lbA.TabIndex = 3;
            this.lbA.Text = "0";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.Location = new System.Drawing.Point(586, 104);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(26, 29);
            this.lbB.TabIndex = 3;
            this.lbB.Text = "0";
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC.Location = new System.Drawing.Point(607, 65);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(26, 29);
            this.lbC.TabIndex = 3;
            this.lbC.Text = "0";
            // 
            // lbD
            // 
            this.lbD.AutoSize = true;
            this.lbD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbD.Location = new System.Drawing.Point(607, 108);
            this.lbD.Name = "lbD";
            this.lbD.Size = new System.Drawing.Size(26, 29);
            this.lbD.TabIndex = 3;
            this.lbD.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "R Esquerda (E):";
            // 
            // lbE
            // 
            this.lbE.AutoSize = true;
            this.lbE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbE.Location = new System.Drawing.Point(625, 61);
            this.lbE.Name = "lbE";
            this.lbE.Size = new System.Drawing.Size(26, 29);
            this.lbE.TabIndex = 3;
            this.lbE.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(439, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "R Direita (D):";
            // 
            // lbF
            // 
            this.lbF.AutoSize = true;
            this.lbF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbF.Location = new System.Drawing.Point(625, 104);
            this.lbF.Name = "lbF";
            this.lbF.Size = new System.Drawing.Size(26, 29);
            this.lbF.TabIndex = 3;
            this.lbF.Text = "0";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.sobe);
            this.tabControl1.Controls.Add(this.direita);
            this.tabControl1.Controls.Add(this.rotacao);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(180, 99);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(737, 271);
            this.tabControl1.TabIndex = 5;
            // 
            // sobe
            // 
            this.sobe.Controls.Add(this.Stz);
            this.sobe.Controls.Add(this.label9);
            this.sobe.Controls.Add(this.Stx);
            this.sobe.Controls.Add(this.label7);
            this.sobe.Controls.Add(this.pictureBox1);
            this.sobe.Controls.Add(this.label1);
            this.sobe.Controls.Add(this.lbA);
            this.sobe.Controls.Add(this.lbB);
            this.sobe.Controls.Add(this.label3);
            this.sobe.Location = new System.Drawing.Point(4, 38);
            this.sobe.Name = "sobe";
            this.sobe.Padding = new System.Windows.Forms.Padding(3);
            this.sobe.Size = new System.Drawing.Size(729, 229);
            this.sobe.TabIndex = 0;
            this.sobe.Text = "Sobe/Desce";
            this.sobe.UseVisualStyleBackColor = true;
            // 
            // direita
            // 
            this.direita.Controls.Add(this.Dtz);
            this.direita.Controls.Add(this.label11);
            this.direita.Controls.Add(this.Dtx);
            this.direita.Controls.Add(this.label13);
            this.direita.Controls.Add(this.pictureBox2);
            this.direita.Controls.Add(this.label4);
            this.direita.Controls.Add(this.lbD);
            this.direita.Controls.Add(this.lbC);
            this.direita.Controls.Add(this.label5);
            this.direita.Location = new System.Drawing.Point(4, 38);
            this.direita.Name = "direita";
            this.direita.Padding = new System.Windows.Forms.Padding(3);
            this.direita.Size = new System.Drawing.Size(729, 229);
            this.direita.TabIndex = 1;
            this.direita.Text = "Direita/Esquerda";
            this.direita.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(331, 217);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // rotacao
            // 
            this.rotacao.Controls.Add(this.pictureBox3);
            this.rotacao.Controls.Add(this.lbF);
            this.rotacao.Controls.Add(this.label6);
            this.rotacao.Controls.Add(this.label8);
            this.rotacao.Controls.Add(this.lbE);
            this.rotacao.Location = new System.Drawing.Point(4, 38);
            this.rotacao.Name = "rotacao";
            this.rotacao.Size = new System.Drawing.Size(729, 229);
            this.rotacao.TabIndex = 2;
            this.rotacao.Text = "Rotação";
            this.rotacao.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(327, 223);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Stz
            // 
            this.Stz.AutoSize = true;
            this.Stz.Location = new System.Drawing.Point(496, 188);
            this.Stz.Name = "Stz";
            this.Stz.Size = new System.Drawing.Size(46, 29);
            this.Stz.TabIndex = 5;
            this.Stz.Text = "Tz:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(444, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 29);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tz:";
            // 
            // Stx
            // 
            this.Stx.AutoSize = true;
            this.Stx.Location = new System.Drawing.Point(496, 159);
            this.Stx.Name = "Stx";
            this.Stx.Size = new System.Drawing.Size(46, 29);
            this.Stx.TabIndex = 7;
            this.Stx.Text = "Tx:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tx:";
            // 
            // Dtz
            // 
            this.Dtz.AutoSize = true;
            this.Dtz.Location = new System.Drawing.Point(491, 193);
            this.Dtz.Name = "Dtz";
            this.Dtz.Size = new System.Drawing.Size(46, 29);
            this.Dtz.TabIndex = 9;
            this.Dtz.Text = "Tz:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(439, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 29);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tz:";
            // 
            // Dtx
            // 
            this.Dtx.AutoSize = true;
            this.Dtx.Location = new System.Drawing.Point(491, 164);
            this.Dtx.Name = "Dtx";
            this.Dtx.Size = new System.Drawing.Size(46, 29);
            this.Dtx.TabIndex = 11;
            this.Dtx.Text = "Tx:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(439, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 29);
            this.label13.TabIndex = 12;
            this.label13.Text = "Tx:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSenha);
            this.tabPage1.Controls.Add(this.txtPorta);
            this.tabPage1.Controls.Add(this.txtUrl);
            this.tabPage1.Controls.Add(this.txtUsuario);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(729, 229);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Configuração";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Url:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(421, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "Porta:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 29);
            this.label14.TabIndex = 0;
            this.label14.Text = "Usuário:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(421, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 29);
            this.label15.TabIndex = 0;
            this.label15.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(133, 119);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(252, 34);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "admin";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(81, 45);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(304, 34);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "192.168.0.10";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(503, 45);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(122, 34);
            this.txtPorta.TabIndex = 1;
            this.txtPorta.Text = "1883";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(511, 119);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(193, 34);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Text = "12345";
            // 
            // lbConectado
            // 
            this.lbConectado.AutoSize = true;
            this.lbConectado.Location = new System.Drawing.Point(560, 403);
            this.lbConectado.Name = "lbConectado";
            this.lbConectado.Size = new System.Drawing.Size(154, 17);
            this.lbConectado.TabIndex = 0;
            this.lbConectado.Text = "Conectado ao Mouse...";
            this.lbConectado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 443);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbConectado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integração Mouse 3D";
            this.tabControl1.ResumeLayout(false);
            this.sobe.ResumeLayout(false);
            this.sobe.PerformLayout();
            this.direita.ResumeLayout(false);
            this.direita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.rotacao.ResumeLayout(false);
            this.rotacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Label lbD;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbF;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sobe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage direita;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage rotacao;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Stz;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Stx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Dtz;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Dtx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbConectado;
    }
}

