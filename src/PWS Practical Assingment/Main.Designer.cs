namespace PWS_Practical_Assingment
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.textBoxPlainIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelN = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.textBoxCipherIn = new System.Windows.Forms.TextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textBoxDecrypted = new System.Windows.Forms.TextBox();
            this.buttonBruteForce = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelOutQ = new System.Windows.Forms.Label();
            this.labelOutP = new System.Windows.Forms.Label();
            this.labelOutPlain = new System.Windows.Forms.Label();
            this.labelOutD = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(89, 12);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(101, 20);
            this.textBoxP.TabIndex = 0;
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(90, 38);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(100, 20);
            this.textBoxQ.TabIndex = 1;
            // 
            // textBoxPlainIn
            // 
            this.textBoxPlainIn.Location = new System.Drawing.Point(77, 88);
            this.textBoxPlainIn.Name = "textBoxPlainIn";
            this.textBoxPlainIn.Size = new System.Drawing.Size(101, 20);
            this.textBoxPlainIn.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Component P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Component Q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Plaintext In";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(197, 4);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(138, 54);
            this.buttonGenerate.TabIndex = 6;
            this.buttonGenerate.Text = "Generate Key";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(6, 11);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(16, 13);
            this.labelN.TabIndex = 7;
            this.labelN.Text = "n:";
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Location = new System.Drawing.Point(6, 24);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(16, 13);
            this.labelE.TabIndex = 8;
            this.labelE.Text = "e:";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(6, 37);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(16, 13);
            this.labelD.TabIndex = 9;
            this.labelD.Text = "d:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelN);
            this.groupBox1.Controls.Add(this.labelD);
            this.groupBox1.Controls.Add(this.labelE);
            this.groupBox1.Location = new System.Drawing.Point(341, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 54);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output Key";
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(184, 84);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(91, 24);
            this.buttonEncrypt.TabIndex = 11;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // textBoxCipherIn
            // 
            this.textBoxCipherIn.Enabled = false;
            this.textBoxCipherIn.Location = new System.Drawing.Point(281, 88);
            this.textBoxCipherIn.Name = "textBoxCipherIn";
            this.textBoxCipherIn.Size = new System.Drawing.Size(164, 20);
            this.textBoxCipherIn.TabIndex = 12;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(15, 114);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(163, 23);
            this.buttonDecrypt.TabIndex = 13;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // textBoxDecrypted
            // 
            this.textBoxDecrypted.Enabled = false;
            this.textBoxDecrypted.Location = new System.Drawing.Point(185, 115);
            this.textBoxDecrypted.Name = "textBoxDecrypted";
            this.textBoxDecrypted.Size = new System.Drawing.Size(260, 20);
            this.textBoxDecrypted.TabIndex = 14;
            // 
            // buttonBruteForce
            // 
            this.buttonBruteForce.Location = new System.Drawing.Point(15, 163);
            this.buttonBruteForce.Name = "buttonBruteForce";
            this.buttonBruteForce.Size = new System.Drawing.Size(430, 49);
            this.buttonBruteForce.TabIndex = 15;
            this.buttonBruteForce.Text = "Attempt a brute force attack";
            this.buttonBruteForce.UseVisualStyleBackColor = true;
            this.buttonBruteForce.Click += new System.EventHandler(this.buttonBruteForce_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 218);
            this.progressBar1.MarqueeAnimationSpeed = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(430, 32);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelOutQ);
            this.groupBox2.Controls.Add(this.labelOutP);
            this.groupBox2.Controls.Add(this.labelOutPlain);
            this.groupBox2.Controls.Add(this.labelOutD);
            this.groupBox2.Location = new System.Drawing.Point(15, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 74);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // labelOutQ
            // 
            this.labelOutQ.AutoSize = true;
            this.labelOutQ.Location = new System.Drawing.Point(6, 29);
            this.labelOutQ.Name = "labelOutQ";
            this.labelOutQ.Size = new System.Drawing.Size(16, 13);
            this.labelOutQ.TabIndex = 3;
            this.labelOutQ.Text = "q:";
            // 
            // labelOutP
            // 
            this.labelOutP.AutoSize = true;
            this.labelOutP.Location = new System.Drawing.Point(6, 16);
            this.labelOutP.Name = "labelOutP";
            this.labelOutP.Size = new System.Drawing.Size(16, 13);
            this.labelOutP.TabIndex = 2;
            this.labelOutP.Text = "p:";
            // 
            // labelOutPlain
            // 
            this.labelOutPlain.AutoSize = true;
            this.labelOutPlain.Location = new System.Drawing.Point(6, 55);
            this.labelOutPlain.Name = "labelOutPlain";
            this.labelOutPlain.Size = new System.Drawing.Size(50, 13);
            this.labelOutPlain.TabIndex = 1;
            this.labelOutPlain.Text = "Plaintext:";
            // 
            // labelOutD
            // 
            this.labelOutD.AutoSize = true;
            this.labelOutD.Location = new System.Drawing.Point(6, 42);
            this.labelOutD.Name = "labelOutD";
            this.labelOutD.Size = new System.Drawing.Size(16, 13);
            this.labelOutD.TabIndex = 0;
            this.labelOutD.Text = "d:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(158, 269);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(177, 20);
            this.numericUpDown1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Time Taken:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "seconds";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 339);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonBruteForce);
            this.Controls.Add(this.textBoxDecrypted);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.textBoxCipherIn);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPlainIn);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.textBoxP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "A Thing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.TextBox textBoxPlainIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox textBoxCipherIn;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBoxDecrypted;
        private System.Windows.Forms.Button buttonBruteForce;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelOutPlain;
        private System.Windows.Forms.Label labelOutD;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelOutQ;
        private System.Windows.Forms.Label labelOutP;
    }
}

