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
using YazilimYapimiProjeOdevi;

namespace YazilimYapimiProjeOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int userID;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-06DR47K\\SQLEXPRESS;Initial Catalog=yazilimYapimiProje;Integrated Security=True;");

    

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void btnGiriş_Click(object sender, EventArgs e) {
            
            string email=textBox1.Text;
            string password=textBox2.Text;

            string hashedPassword=SecurityHelper.ComputeSha256Hash(password);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select userID from users where email=@email and password=@password",conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", hashedPassword);
            SqlDataReader reader=cmd.ExecuteReader();
            if (reader.HasRows) {
                while (reader.Read())
                {
                    userID = reader.GetInt32(0);
                    
                }
                Menü menü = new Menü();
                menü.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı");
            }

            reader.Close();
            conn.Close();

            
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl kayit = new KayitOl();
            kayit.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreYenile sifreYenile = new SifreYenile();
            sifreYenile.ShowDialog();
        }
        
    }
}
