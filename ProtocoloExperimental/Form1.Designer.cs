namespace ProtocoloExperimental
{
    partial class MainForm
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
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.btStart = new System.Windows.Forms.Button();
            this.TimerOne = new System.Windows.Forms.Timer(this.components);
            this.lbCountT = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbCountP = new System.Windows.Forms.Label();
            this.lbStartMessage = new System.Windows.Forms.Label();
            this.TimerTwo = new System.Windows.Forms.Timer(this.components);
            this.pnMain = new System.Windows.Forms.Panel();
            this.lbMoviment = new System.Windows.Forms.Label();
            this.pbTrigger = new System.Windows.Forms.PictureBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btOne = new System.Windows.Forms.Button();
            this.pbTwo = new System.Windows.Forms.PictureBox();
            this.TimerThree = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrigger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMain
            // 
            this.pbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMain.BackColor = System.Drawing.Color.White;
            this.pbMain.Location = new System.Drawing.Point(421, 12);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(371, 507);
            this.pbMain.TabIndex = 1;
            this.pbMain.TabStop = false;
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(99, 64);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(178, 70);
            this.btStart.TabIndex = 3;
            this.btStart.Text = "Iniciar a coleta";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.Bt1_Click);
            // 
            // TimerOne
            // 
            this.TimerOne.Interval = 1;
            this.TimerOne.Tick += new System.EventHandler(this.TimerOne_Tick);
            // 
            // lbCountT
            // 
            this.lbCountT.AutoSize = true;
            this.lbCountT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountT.Location = new System.Drawing.Point(293, 224);
            this.lbCountT.Name = "lbCountT";
            this.lbCountT.Size = new System.Drawing.Size(23, 25);
            this.lbCountT.TabIndex = 4;
            this.lbCountT.Text = "0";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(22, 224);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(265, 25);
            this.lb2.TabIndex = 5;
            this.lb2.Text = "Número total de movimentos:";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(22, 189);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(298, 25);
            this.lb1.TabIndex = 6;
            this.lb1.Text = "Número de movimentos da série:";
            // 
            // lbCountP
            // 
            this.lbCountP.AutoSize = true;
            this.lbCountP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountP.Location = new System.Drawing.Point(326, 189);
            this.lbCountP.Name = "lbCountP";
            this.lbCountP.Size = new System.Drawing.Size(23, 25);
            this.lbCountP.TabIndex = 7;
            this.lbCountP.Text = "0";
            // 
            // lbStartMessage
            // 
            this.lbStartMessage.AutoSize = true;
            this.lbStartMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartMessage.Location = new System.Drawing.Point(12, 9);
            this.lbStartMessage.Name = "lbStartMessage";
            this.lbStartMessage.Size = new System.Drawing.Size(0, 63);
            this.lbStartMessage.TabIndex = 8;
            // 
            // TimerTwo
            // 
            this.TimerTwo.Interval = 400;
            this.TimerTwo.Tick += new System.EventHandler(this.TimerTwo_Tick);
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.Controls.Add(this.lbMoviment);
            this.pnMain.Controls.Add(this.pbTrigger);
            this.pnMain.Controls.Add(this.lb3);
            this.pnMain.Controls.Add(this.tbName);
            this.pnMain.Controls.Add(this.lbCountP);
            this.pnMain.Controls.Add(this.lbStartMessage);
            this.pnMain.Controls.Add(this.lb1);
            this.pnMain.Controls.Add(this.btOne);
            this.pnMain.Controls.Add(this.lb2);
            this.pnMain.Controls.Add(this.btStart);
            this.pnMain.Controls.Add(this.lbCountT);
            this.pnMain.Controls.Add(this.pbTwo);
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(868, 526);
            this.pnMain.TabIndex = 9;
            // 
            // lbMoviment
            // 
            this.lbMoviment.AutoSize = true;
            this.lbMoviment.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoviment.Location = new System.Drawing.Point(3, 431);
            this.lbMoviment.Name = "lbMoviment";
            this.lbMoviment.Size = new System.Drawing.Size(300, 76);
            this.lbMoviment.TabIndex = 14;
            this.lbMoviment.Text = "Repouso";
            // 
            // pbTrigger
            // 
            this.pbTrigger.Location = new System.Drawing.Point(27, 12);
            this.pbTrigger.Name = "pbTrigger";
            this.pbTrigger.Size = new System.Drawing.Size(10, 10);
            this.pbTrigger.TabIndex = 12;
            this.pbTrigger.TabStop = false;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(22, 156);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(186, 25);
            this.lb3.TabIndex = 11;
            this.lb3.Text = "Nome do voluntário:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(214, 153);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(145, 30);
            this.tbName.TabIndex = 10;
            this.tbName.Text = "VOLUNTÁRIO";
            // 
            // btOne
            // 
            this.btOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOne.Location = new System.Drawing.Point(24, 12);
            this.btOne.Name = "btOne";
            this.btOne.Size = new System.Drawing.Size(10, 10);
            this.btOne.TabIndex = 0;
            this.btOne.Text = "Pronto";
            this.btOne.UseVisualStyleBackColor = true;
            this.btOne.Click += new System.EventHandler(this.BtOne_Click);
            // 
            // pbTwo
            // 
            this.pbTwo.Location = new System.Drawing.Point(24, 12);
            this.pbTwo.Name = "pbTwo";
            this.pbTwo.Size = new System.Drawing.Size(10, 10);
            this.pbTwo.TabIndex = 9;
            this.pbTwo.TabStop = false;
            // 
            // TimerThree
            // 
            this.TimerThree.Interval = 1000;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 526);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.pnMain);
            this.Name = "MainForm";
            this.Text = "Protocolo Experiental";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrigger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Timer TimerOne;
        private System.Windows.Forms.Label lbCountT;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbCountP;
        private System.Windows.Forms.Label lbStartMessage;
        private System.Windows.Forms.Timer TimerTwo;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btOne;
        private System.Windows.Forms.PictureBox pbTwo;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.PictureBox pbTrigger;
        private System.Windows.Forms.Label lbMoviment;
        private System.Windows.Forms.Timer TimerThree;
    }
}

