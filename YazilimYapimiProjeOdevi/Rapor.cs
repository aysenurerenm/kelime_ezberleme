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
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;

namespace YazilimYapimiProjeOdevi
{
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-06DR47K\\SQLEXPRESS;Initial Catalog=yazilimYapimiProje;Integrated Security=True;");

        
        

        private void Rapor_Load(object sender, EventArgs e)
        {
            RaporuGüncelle();
            
        }

        private void RaporuGüncelle()
        {
            int userID = Form1.userID;
            int[] asamalar = new int[6];

            using (SqlConnection con = new SqlConnection(conn.ConnectionString))
            {

                con.Open();

                //Toplam Kelime
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM words", con);
                txtBoxTotalWords.Text =cmd.ExecuteScalar().ToString();

                //Bilinen Kelime
                cmd=new SqlCommand("SELECT COUNT(*) FROM wordsStation WHERE userID=@userID AND isLearned=1",con);
                cmd.Parameters.AddWithValue("@userID", Form1.userID);
                txtBoxKnownWords.Text =cmd.ExecuteScalar().ToString();

                //Görülmeyen Kelime
                cmd = new SqlCommand(@"SELECT COUNT(*) FROM words
                                       WHERE wordsID NOT IN
                                        (SELECT wordsID FROM wordsStation WHERE userID=@userID )",con);
                cmd.Parameters.AddWithValue("@userID", Form1.userID);
                txtBoxUnseenWords.Text= cmd.ExecuteScalar().ToString();

                //Aşamalar
                cmd = new SqlCommand(@"SELECT correctCount, COUNT(*) FROM wordsStation 
                                       WHERE userID=@userID AND correctCount BETWEEN 1 AND 6 
                                       GROUP BY correctCount", con);
                cmd.Parameters.AddWithValue("@userID", userID);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int asama = Convert.ToInt32(dr[0]);
                    int count = Convert.ToInt32(dr[1]);
                    asamalar[asama - 1] = count;
                }
                dr.Close();

                txtBoxStage1.Text = asamalar[0].ToString();
                txtBoxStage2.Text = asamalar[1].ToString();
                txtBoxStage3.Text = asamalar[2].ToString();
                txtBoxStage4.Text = asamalar[3].ToString();
                txtBoxStage5.Text = asamalar[4].ToString();
                txtBoxStage6.Text = asamalar[5].ToString();

                //Grfik güncelleme
                chartStages.Series.Clear();
                Series series = new Series("Aşamalar");
                series.ChartType = SeriesChartType.Pie;
                for (int i = 0; i < 6; i++)
                {
                    series.Points.AddXY($"Aşama {i + 1}", asamalar[i]);
                }
                chartStages.Series.Add(series);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RaporuGüncelle();
        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawString("Kullanıcı Raporu", new Font("Arial", 16), Brushes.Black, 100, 50);
                ev.Graphics.DrawString($"Toplam Kelime: {txtBoxTotalWords.Text}", new Font("Arial", 12), Brushes.Black, 100, 100);
                ev.Graphics.DrawString($"Bilinen Kelime: {txtBoxKnownWords.Text}", new Font("Arial", 12), Brushes.Black, 100, 120);
                ev.Graphics.DrawString($"Görülmeyen Kelime: {txtBoxUnseenWords.Text}", new Font("Arial", 12), Brushes.Black, 100, 140);
                ev.Graphics.DrawString($"Aşama 1: {txtBoxStage1.Text}", new Font("Arial", 12), Brushes.Black, 100, 160);
                ev.Graphics.DrawString($"Aşama 2: {txtBoxStage2.Text}", new Font("Arial", 12), Brushes.Black, 100, 180);
                ev.Graphics.DrawString($"Aşama 3: {txtBoxStage3.Text}", new Font("Arial", 12), Brushes.Black, 100, 200);
                ev.Graphics.DrawString($"Aşama 4: {txtBoxStage4.Text}", new Font("Arial", 12), Brushes.Black, 100, 220);
                ev.Graphics.DrawString($"Aşama 5: {txtBoxStage5.Text}", new Font("Arial", 12), Brushes.Black, 100, 240);
                ev.Graphics.DrawString($"Aşama 6: {txtBoxStage6.Text}", new Font("Arial", 12), Brushes.Black, 100, 260);
            };

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;
            if (printDialog.ShowDialog() == DialogResult.OK)
                pd.Print();
        }
    }
    }
