namespace WindowsFormsApplication6
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxYmin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxXmin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxYmax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxXmax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxCi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxLiczbaIteracji = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(344, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 900);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rysuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Współrzędne płaszczyzny zespolonej";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 26);
            this.button2.TabIndex = 3;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxYmin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxXmin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wartość minimalna";
            // 
            // textBoxYmin
            // 
            this.textBoxYmin.Location = new System.Drawing.Point(126, 45);
            this.textBoxYmin.Name = "textBoxYmin";
            this.textBoxYmin.Size = new System.Drawing.Size(100, 20);
            this.textBoxYmin.TabIndex = 3;
            this.textBoxYmin.Text = "-1,2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y - część urojona";
            // 
            // textBoxXmin
            // 
            this.textBoxXmin.Location = new System.Drawing.Point(126, 15);
            this.textBoxXmin.Name = "textBoxXmin";
            this.textBoxXmin.Size = new System.Drawing.Size(100, 20);
            this.textBoxXmin.TabIndex = 1;
            this.textBoxXmin.Text = "-1,5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "X - część rzeczywista";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxYmax);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxXmax);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(16, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 78);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wartość maksymalna";
            // 
            // textBoxYmax
            // 
            this.textBoxYmax.Location = new System.Drawing.Point(126, 45);
            this.textBoxYmax.Name = "textBoxYmax";
            this.textBoxYmax.Size = new System.Drawing.Size(100, 20);
            this.textBoxYmax.TabIndex = 3;
            this.textBoxYmax.Text = "1,2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Y - część urojona";
            // 
            // textBoxXmax
            // 
            this.textBoxXmax.Location = new System.Drawing.Point(126, 15);
            this.textBoxXmax.Name = "textBoxXmax";
            this.textBoxXmax.Size = new System.Drawing.Size(100, 20);
            this.textBoxXmax.TabIndex = 1;
            this.textBoxXmax.Text = "1,5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "X - część rzeczywista";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(294, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 26);
            this.button3.TabIndex = 6;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 583);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "Wyjdź";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(11, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Zbiór Julii";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxCi);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxCr);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(16, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 78);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // textBoxCi
            // 
            this.textBoxCi.Location = new System.Drawing.Point(126, 45);
            this.textBoxCi.Name = "textBoxCi";
            this.textBoxCi.Size = new System.Drawing.Size(100, 20);
            this.textBoxCi.TabIndex = 3;
            this.textBoxCi.Text = "0,19";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "i - część urojona";
            // 
            // textBoxCr
            // 
            this.textBoxCr.Location = new System.Drawing.Point(126, 15);
            this.textBoxCr.Name = "textBoxCr";
            this.textBoxCr.Size = new System.Drawing.Size(100, 20);
            this.textBoxCr.TabIndex = 1;
            this.textBoxCr.Text = "-0,73";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "r - część rzeczywista";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Parametr c zbioru Julii";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(294, 268);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 26);
            this.button5.TabIndex = 11;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Liczba iteracji";
            // 
            // textBoxLiczbaIteracji
            // 
            this.textBoxLiczbaIteracji.Location = new System.Drawing.Point(142, 382);
            this.textBoxLiczbaIteracji.Name = "textBoxLiczbaIteracji";
            this.textBoxLiczbaIteracji.Size = new System.Drawing.Size(100, 20);
            this.textBoxLiczbaIteracji.TabIndex = 4;
            this.textBoxLiczbaIteracji.Text = "255";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(294, 376);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 26);
            this.button6.TabIndex = 13;
            this.button6.Text = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 540);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "praca w toku...";
            this.label11.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 961);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBoxLiczbaIteracji);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Zbiór Julii";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxYmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxXmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxYmax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxXmax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxCi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxLiczbaIteracji;
        private System.Windows.Forms.Button button6;

        public void PokazNapis(bool widoczny)
        {
            Visible = widoczny;
        }

        private System.Windows.Forms.Label label11;
    }
}

