namespace YazilimYapimiProjeOdevi
{
    partial class Menü
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
            this.btnTest = new System.Windows.Forms.Button();
            this.btnKelimeler = new System.Windows.Forms.Button();
            this.btnWordChain = new System.Windows.Forms.Button();
            this.btnBulmaca = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTest.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTest.Location = new System.Drawing.Point(80, 82);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(150, 75);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "TEST";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnKelimeler
            // 
            this.btnKelimeler.BackColor = System.Drawing.Color.LimeGreen;
            this.btnKelimeler.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKelimeler.Location = new System.Drawing.Point(294, 82);
            this.btnKelimeler.Name = "btnKelimeler";
            this.btnKelimeler.Size = new System.Drawing.Size(150, 75);
            this.btnKelimeler.TabIndex = 1;
            this.btnKelimeler.Text = "KELİMELER";
            this.btnKelimeler.UseVisualStyleBackColor = false;
            this.btnKelimeler.Click += new System.EventHandler(this.btnKelimeler_Click);
            // 
            // btnWordChain
            // 
            this.btnWordChain.BackColor = System.Drawing.Color.DeepPink;
            this.btnWordChain.ForeColor = System.Drawing.SystemColors.Control;
            this.btnWordChain.Location = new System.Drawing.Point(521, 82);
            this.btnWordChain.Name = "btnWordChain";
            this.btnWordChain.Size = new System.Drawing.Size(150, 75);
            this.btnWordChain.TabIndex = 2;
            this.btnWordChain.Text = "WORD CHAİN";
            this.btnWordChain.UseVisualStyleBackColor = false;
            // 
            // btnBulmaca
            // 
            this.btnBulmaca.BackColor = System.Drawing.Color.Gold;
            this.btnBulmaca.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBulmaca.Location = new System.Drawing.Point(80, 252);
            this.btnBulmaca.Name = "btnBulmaca";
            this.btnBulmaca.Size = new System.Drawing.Size(150, 75);
            this.btnBulmaca.TabIndex = 3;
            this.btnBulmaca.Text = "BULMACA";
            this.btnBulmaca.UseVisualStyleBackColor = false;
            this.btnBulmaca.Click += new System.EventHandler(this.btnBulmaca_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.Color.DarkViolet;
            this.btnRapor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRapor.Location = new System.Drawing.Point(294, 252);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(150, 75);
            this.btnRapor.TabIndex = 4;
            this.btnRapor.Text = "RAPOR";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAyarlar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAyarlar.Location = new System.Drawing.Point(521, 252);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(150, 75);
            this.btnAyarlar.TabIndex = 5;
            this.btnAyarlar.Text = "AYARLAR";
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(708, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 27);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Menü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnBulmaca);
            this.Controls.Add(this.btnWordChain);
            this.Controls.Add(this.btnKelimeler);
            this.Controls.Add(this.btnTest);
            this.Name = "Menü";
            this.Text = "Menü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnKelimeler;
        private System.Windows.Forms.Button btnWordChain;
        private System.Windows.Forms.Button btnBulmaca;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnExit;
    }
}