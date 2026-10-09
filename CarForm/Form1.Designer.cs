namespace CarForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.carpma = new System.Windows.Forms.PictureBox();
            this.araba2 = new System.Windows.Forms.PictureBox();
            this.araba1 = new System.Windows.Forms.PictureBox();
            this.bizimaraba = new System.Windows.Forms.PictureBox();
            this.yol = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Puan = new System.Windows.Forms.Label();
            this.Btn_baslat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_mainScore = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bizimaraba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.carpma);
            this.panel1.Controls.Add(this.araba2);
            this.panel1.Controls.Add(this.araba1);
            this.panel1.Controls.Add(this.bizimaraba);
            this.panel1.Controls.Add(this.yol);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 644);
            this.panel1.TabIndex = 0;
            // 
            // carpma
            // 
            this.carpma.Image = global::CarForm.Properties.Resources.explosion;
            this.carpma.Location = new System.Drawing.Point(300, 395);
            this.carpma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(51, 49);
            this.carpma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carpma.TabIndex = 4;
            this.carpma.TabStop = false;
            this.carpma.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // araba2
            // 
            this.araba2.Image = global::CarForm.Properties.Resources.araba5;
            this.araba2.Location = new System.Drawing.Point(452, 70);
            this.araba2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.araba2.Name = "araba2";
            this.araba2.Size = new System.Drawing.Size(92, 165);
            this.araba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.araba2.TabIndex = 3;
            this.araba2.TabStop = false;
            // 
            // araba1
            // 
            this.araba1.Image = global::CarForm.Properties.Resources.araba9;
            this.araba1.Location = new System.Drawing.Point(96, 70);
            this.araba1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.araba1.Name = "araba1";
            this.araba1.Size = new System.Drawing.Size(92, 186);
            this.araba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.araba1.TabIndex = 2;
            this.araba1.TabStop = false;
            // 
            // bizimaraba
            // 
            this.bizimaraba.Image = global::CarForm.Properties.Resources.araba8;
            this.bizimaraba.Location = new System.Drawing.Point(280, 468);
            this.bizimaraba.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bizimaraba.Name = "bizimaraba";
            this.bizimaraba.Size = new System.Drawing.Size(100, 149);
            this.bizimaraba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bizimaraba.TabIndex = 1;
            this.bizimaraba.TabStop = false;
            // 
            // yol
            // 
            this.yol.Image = global::CarForm.Properties.Resources.yol;
            this.yol.Location = new System.Drawing.Point(-12, -314);
            this.yol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yol.Name = "yol";
            this.yol.Size = new System.Drawing.Size(684, 954);
            this.yol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol.TabIndex = 0;
            this.yol.TabStop = false;
            this.yol.Click += new System.EventHandler(this.yol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(512, 678);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Point :";
            // 
            // lbl_Puan
            // 
            this.lbl_Puan.AutoSize = true;
            this.lbl_Puan.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Puan.Location = new System.Drawing.Point(661, 678);
            this.lbl_Puan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Puan.Name = "lbl_Puan";
            this.lbl_Puan.Size = new System.Drawing.Size(26, 29);
            this.lbl_Puan.TabIndex = 2;
            this.lbl_Puan.Text = "0";
            // 
            // Btn_baslat
            // 
            this.Btn_baslat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_baslat.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_baslat.Location = new System.Drawing.Point(8, 730);
            this.Btn_baslat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_baslat.Name = "Btn_baslat";
            this.Btn_baslat.Size = new System.Drawing.Size(684, 66);
            this.Btn_baslat.TabIndex = 3;
            this.Btn_baslat.Text = "Start Game";
            this.Btn_baslat.UseVisualStyleBackColor = false;
            this.Btn_baslat.Click += new System.EventHandler(this.Btn_baslat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 678);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "MainPoint :";
            // 
            // lbl_mainScore
            // 
            this.lbl_mainScore.AutoSize = true;
            this.lbl_mainScore.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mainScore.Location = new System.Drawing.Point(197, 678);
            this.lbl_mainScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mainScore.Name = "lbl_mainScore";
            this.lbl_mainScore.Size = new System.Drawing.Size(26, 29);
            this.lbl_mainScore.TabIndex = 5;
            this.lbl_mainScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(723, 843);
            this.Controls.Add(this.lbl_mainScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_baslat);
            this.Controls.Add(this.lbl_Puan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarRace";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bizimaraba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox bizimaraba;
        private System.Windows.Forms.PictureBox araba2;
        private System.Windows.Forms.PictureBox araba1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Puan;
        private System.Windows.Forms.Button Btn_baslat;
        private System.Windows.Forms.PictureBox carpma;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox yol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_mainScore;
    }
}

