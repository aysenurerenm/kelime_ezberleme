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
using System.Drawing.Text;

namespace YazilimYapimiProjeOdevi
{
    public partial class KelimeEkle : Form
    {
        public KelimeEkle()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-06DR47K\\SQLEXPRESS;Initial Catalog=yazilimYapimiProje;Integrated Security=True;");
        private void button1_Click(object sender, EventArgs e)
        {
            string İngilizce=textBox1.Text.Trim();
            string Türkçe=textBox2.Text.Trim();
            string ÖrnekCümle=textBox3.Text.Trim();
            string Resim=textBox4.Text.Trim();

            if (string.IsNullOrEmpty(İngilizce) || string.IsNullOrEmpty(Türkçe)){

                MessageBox.Show("Lütfen her iki alanı da doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try {
                conn.Open();
                string checkQuery = "select count(*) from words where englishWord=@ingilizce";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@ingilizce", İngilizce);

                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0) {
                    MessageBox.Show("Bu İngilizce kelime zaten veritabanında mevcut.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; }

                string insertQuery = "INSERT INTO words(englishWord,turkishWord,image) VALUES(@ingilizce,@türkçe,@resim); SELECT SCOPE_IDENTITY();";
                int insertWordID;
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@ingilizce", İngilizce);
                insertCmd.Parameters.AddWithValue("@türkçe", Türkçe);
                insertCmd.Parameters.AddWithValue("@resim",Resim);

                Object result = insertCmd.ExecuteScalar();
                insertWordID = Convert.ToInt32(result);

                

                if (!string.IsNullOrEmpty(ÖrnekCümle))
                {
                    string insertSentenceQuery = "INSERT INTO wordsSamples(wordsID,samples) values(@wordsID,@samples)";
                    SqlCommand insertSentenceCmd = new SqlCommand(insertSentenceQuery, conn);
                    insertSentenceCmd.Parameters.AddWithValue("@wordsID", insertWordID);
                    insertSentenceCmd.Parameters.AddWithValue("@samples", ÖrnekCümle);

                    insertSentenceCmd.ExecuteNonQuery(); 
                }

                
                MessageBox.Show("Kelime başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                
            }
            catch(Exception ex) {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
