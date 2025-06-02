namespace YazilimYapimiProjeOdevi
{
    partial class KelimeEkle
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
            this.lblİngilizce = new System.Windows.Forms.Label();
            this.lblTürkçe = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblİngilizce
            // 
            this.lblİngilizce.AutoSize = true;
            this.lblİngilizce.ForeColor = System.Drawing.SystemColors.Control;
            this.lblİngilizce.Location = new System.Drawing.Point(163, 52);
            this.lblİngilizce.Name = "lblİngilizce";
            this.lblİngilizce.Size = new System.Drawing.Size(69, 16);
            this.lblİngilizce.TabIndex = 0;
            this.lblİngilizce.Text = "İNGİLİZCE";
            // 
            // lblTürkçe
            // 
            this.lblTürkçe.AutoSize = true;
            this.lblTürkçe.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTürkçe.Location = new System.Drawing.Point(170, 100);
            this.lblTürkçe.Name = "lblTürkçe";
            this.lblTürkçe.Size = new System.Drawing.Size(62, 16);
            this.lblTürkçe.TabIndex = 1;
            this.lblTürkçe.Text = "TÜRKÇE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(323, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 22);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "KELİME EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(144, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ÖRNEK CÜMLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(188, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "RESİM";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(323, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(192, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(323, 241);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(192, 22);
            this.textBox4.TabIndex = 8;
            // 
            // KelimeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTürkçe);
            this.Controls.Add(this.lblİngilizce);
            this.Name = "KelimeEkle";
            this.Text = "KelimeEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblİngilizce;
        private System.Windows.Forms.Label lblTürkçe;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}