namespace YazilimYapimiProjeOdevi
{
    partial class Kelimeler
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
            this.btnSözlük = new System.Windows.Forms.Button();
            this.btnKelimeEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSözlük
            // 
            this.btnSözlük.Location = new System.Drawing.Point(122, 137);
            this.btnSözlük.Name = "btnSözlük";
            this.btnSözlük.Size = new System.Drawing.Size(200, 100);
            this.btnSözlük.TabIndex = 0;
            this.btnSözlük.Text = "SÖZLÜK";
            this.btnSözlük.UseVisualStyleBackColor = true;
            this.btnSözlük.Click += new System.EventHandler(this.btnSözlük_Click);
            // 
            // btnKelimeEkle
            // 
            this.btnKelimeEkle.Location = new System.Drawing.Point(436, 138);
            this.btnKelimeEkle.Name = "btnKelimeEkle";
            this.btnKelimeEkle.Size = new System.Drawing.Size(200, 100);
            this.btnKelimeEkle.TabIndex = 1;
            this.btnKelimeEkle.Text = "KELİME EKLE";
            this.btnKelimeEkle.UseVisualStyleBackColor = true;
            this.btnKelimeEkle.Click += new System.EventHandler(this.btnKelimeEkle_Click);
            // 
            // Kelimeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKelimeEkle);
            this.Controls.Add(this.btnSözlük);
            this.Name = "Kelimeler";
            this.Text = "Kelimeler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSözlük;
        private System.Windows.Forms.Button btnKelimeEkle;
    }
}