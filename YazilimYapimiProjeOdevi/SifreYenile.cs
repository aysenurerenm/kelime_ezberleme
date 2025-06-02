using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace YazilimYapimiProjeOdevi
{
    public partial class SifreYenile : Form
    {
        public SifreYenile()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-06DR47K\\SQLEXPRESS;Initial Catalog=yazilimYapimiProje;Integrated Security=True;");

        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnSifre_Click(object sender, EventArgs e)
        {
            string email=textBox1.Text;
            string yenişifre=textBox2.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(yenişifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            if (yenişifre.Length < 6)
            {
                MessageBox.Show("Şifre en az 6 karakter olmalıdır.");
                return;
            }
            string hashedPassword = ComputeSha256Hash(yenişifre);

            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE users Set password=@şifre where email=@email", conn);
            cmd.Parameters.AddWithValue("@şifre", hashedPassword);
            cmd.Parameters.AddWithValue("@email", email);

            int result=cmd.ExecuteNonQuery();
            conn.Close();

            if (result > 0)
            {
                MessageBox.Show("Şifreniz başarıyla güncellendi.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Bu email adresine ait bir kullanıcı bulunamadı");
            }

        }
    }
}
