namespace YazilimYapimiProjeOdevi
{
    partial class SifreYenile
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSifre = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblYeniSifre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(352, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(352, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 22);
            this.textBox2.TabIndex = 1;
            // 
            // btnSifre
            // 
            this.btnSifre.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSifre.Location = new System.Drawing.Point(330, 271);
            this.btnSifre.Name = "btnSifre";
            this.btnSifre.Size = new System.Drawing.Size(152, 54);
            this.btnSifre.TabIndex = 2;
            this.btnSifre.Text = "ŞİFREYİ YENİLE";
            this.btnSifre.UseVisualStyleBackColor = true;
            this.btnSifre.Click += new System.EventHandler(this.btnSifre_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Pink;
            this.lblEmail.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEmail.Location = new System.Drawing.Point(196, 76);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "EMAİL";
            // 
            // lblYeniSifre
            // 
            this.lblYeniSifre.AutoSize = true;
            this.lblYeniSifre.ForeColor = System.Drawing.Color.DarkRed;
            this.lblYeniSifre.Location = new System.Drawing.Point(196, 166);
            this.lblYeniSifre.Name = "lblYeniSifre";
            this.lblYeniSifre.Size = new System.Drawing.Size(80, 16);
            this.lblYeniSifre.TabIndex = 4;
            this.lblYeniSifre.Text = "YENİ ŞİFRE";
            // 
            // SifreYenile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblYeniSifre);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnSifre);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "SifreYenile";
            this.Text = "SifreYenile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSifre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblYeniSifre;
    }
}