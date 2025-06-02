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
using System.IO;

namespace YazilimYapimiProjeOdevi
{
    public partial class Sözlük : Form
    {
        
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-06DR47K\\SQLEXPRESS;Initial Catalog=yazilimYapimiProje;Integrated Security=True;");
        public Sözlük()
        {
            InitializeComponent();
        }

        private void Sözlük_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.RowTemplate.Height = 64;
            dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AllowUserToAddRows=false;
            dataGridView1.SelectionMode=DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Columns.Add("english", "İngilizce");
            dataGridView1.Columns.Add("turkish", "Türkçe");
            

            DataGridViewImageColumn imageCol=new DataGridViewImageColumn();
            imageCol.HeaderText = "Resim";
            imageCol.ImageLayout=DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns.Add(imageCol);
            dataGridView1.Columns.Add("sample", "Örnek Cümle");

            kelimeleriGetir();
        }

        private void kelimeleriGetir() { 
        
            dataGridView1.Rows.Clear();

            string query= "select  W.englishWord, W.turkishWord, W.image, S.samples FROM words W LEFT JOIN wordsSamples S ON W.wordsID = S.wordsID  ORDER BY NEWID();";
            SqlCommand cmd = new SqlCommand(query, conn);
            
          

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {
                string ingilizce = reader["englishWord"].ToString();
                string türkçe = reader["turkishWord"].ToString();
                string ornek = reader["samples"]==DBNull.Value ? "-"  :reader["samples"].ToString();
                string resimYolu = reader["image"].ToString();
                Image img = null;
                if (!string.IsNullOrWhiteSpace(resimYolu) && File.Exists(resimYolu))
                {
                    try
                    {
                        img = Image.FromFile(resimYolu);
                    }
                    catch
                    {
                        img = null;
                    }
                }
             
                dataGridView1.Rows.Add(ingilizce,türkçe,img,ornek);
            }
            conn.Close();
        }
    }
}
