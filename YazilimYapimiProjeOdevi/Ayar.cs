using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimYapimiProjeOdevi
{
    public partial class Ayar : Form
    {
        public Ayar()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-06DR47K\\SQLEXPRESS;Initial Catalog=yazilimYapimiProje;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int newWordCount;
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    // Eğer kullanıcı bir değer girmediyse default 10 kullan
                    newWordCount = 10;
                }
                else
                {
                    newWordCount = Convert.ToInt32(textBox1.Text);
                    if (newWordCount <= 0 || newWordCount > 100000)
                    {
                        throw new Exception("Kelime Sayısı pozitif ve 100000'den küçük olmalıdır.");
                    }
                }

                if (Form1.userID == 0)
                {
                    MessageBox.Show("Geçerli bir kullanıcı ID'si bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                conn.Open();

                // Kullanıcı için kayıt var mı kontrol et
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM settings WHERE userID=@userID", conn);
                checkCmd.Parameters.Add("@userID", SqlDbType.Int).Value = Form1.userID;
                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    // Kayıt yok, yeni kayıt ekle default 10 olarak veya kullanıcının girdiği değerle
                    SqlCommand insertCmd = new SqlCommand("INSERT INTO settings (userID, setWordCount) VALUES (@userID, @setWordCount)", conn);
                    insertCmd.Parameters.Add("@userID", SqlDbType.Int).Value = Form1.userID;
                    insertCmd.Parameters.Add("@setWordCount", SqlDbType.Int).Value = newWordCount;
                    insertCmd.ExecuteNonQuery();
                }
                else
                {
                    // Kayıt varsa güncelle
                    SqlCommand updateCmd = new SqlCommand("UPDATE settings SET setWordCount=@setWordCount WHERE userID=@userID", conn);
                    updateCmd.Parameters.Add("@setWordCount", SqlDbType.Int).Value = newWordCount;
                    updateCmd.Parameters.Add("@userID", SqlDbType.Int).Value = Form1.userID;
                    updateCmd.ExecuteNonQuery();
                }

                conn.Close();

                MessageBox.Show("Kelime sayısı başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen sadece sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

