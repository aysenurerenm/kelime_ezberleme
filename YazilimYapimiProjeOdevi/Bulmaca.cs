using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using YazilimYapimiProjeOdevi;

namespace yazilimyapimiprojem
{
    public partial class Bulmaca : Form
    {
        private string targetWord = "";  // Veritabanından gelen kelime
        private int attempts = 0;        // Kullanıcının yaptığı tahmin sayısı
        private int maxAttempts = 6;     // Maksimum tahmin hakkı
        private List<Label> letterBoxes = new List<Label>(); // Harf kutuları

        public Bulmaca()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Veritabanından rastgele kelime al
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-06DR47K\SQLEXPRESS;Initial Catalog=yazilimYapimiProje;Integrated Security=True;"))

                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 w.englishWord FROM Words w INNER JOIN WordsStation ws ON w.wordsID=ws.wordsID WHERE ws.islearned=1 AND ws.userID = @userID   ORDER BY NEWID()", conn);
                   
                    cmd.Parameters.AddWithValue("@userID", Form1.userID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        targetWord = reader[0].ToString().ToLower();
                    }
                    else
                    {
                        MessageBox.Show("Bilinen kelime bulunamadı");
                        btnSubmit.Enabled = false;
                        return;
                    }

                        wordlength.Text = "Kelime Uzunluğu: " + targetWord.Length;
                }

                lblAttempts.Text = "Kalan Hak: " + maxAttempts;
                CreateLetterBoxes(targetWord.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
                btnSubmit.Enabled = false;
            }
        }

        // Kutuları oluştur
        private void CreateLetterBoxes(int length)
        {
            flowLayoutPanelLetters.Controls.Clear();
            letterBoxes.Clear();

            for (int i = 0; i < length; i++)
            {
                Label lbl = new Label();
                lbl.Text = "_";
                lbl.Width = 35;
                lbl.Height = 35;
                lbl.Font = new Font("Arial", 16, FontStyle.Bold);
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.Margin = new Padding(3);

                flowLayoutPanelLetters.Controls.Add(lbl);
                letterBoxes.Add(lbl);
            }
        }

        // Tahmin butonu
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string guess = txtGuess.Text.Trim().ToLower();

            if (guess.Length != targetWord.Length)
            {
                MessageBox.Show($"⚠ Tahmin ettiğiniz kelime {targetWord.Length} harfli olmalı!");
                return;
            }

            attempts++;
            bool allCorrect = true;
            bool[] targetLetterUsed = new bool[targetWord.Length];

            for (int i = 0; i < targetWord.Length; i++)
            {
                if (guess[i] == targetWord[i])
                {
                    letterBoxes[i].Text = guess[i].ToString().ToUpper();
                    letterBoxes[i].BackColor = Color.Green;
                    letterBoxes[i].ForeColor = Color.White;
                    targetLetterUsed[i] = true;
                }
                else
                {
                    letterBoxes[i].Text = guess[i].ToString().ToUpper();
                    allCorrect = false;
                }
            }

            for (int i = 0; i < targetWord.Length; i++)
            {
                if (letterBoxes[i].BackColor != Color.Green)
                {
                    bool found = false;
                    for (int j = 0; j < targetWord.Length; j++)
                    {
                        if (!targetLetterUsed[j] && guess[i] == targetWord[j])
                        {
                            found = true;
                            targetLetterUsed[j] = true;
                            break;
                        }
                    }

                    if (found)
                    {
                        letterBoxes[i].BackColor = Color.Goldenrod;
                        letterBoxes[i].ForeColor = Color.White;
                    }
                    else
                    {
                        letterBoxes[i].BackColor = Color.Red;
                        letterBoxes[i].ForeColor = Color.White;
                    }
                }
            }

            lblResult.Text += $"Tahmin {attempts}: {guess.ToUpper()}\n";

            if (allCorrect)
            {
                MessageBox.Show("🎉 Tebrikler! Kelimeyi doğru tahmin ettiniz.");
                btnSubmit.Enabled = false;
            }
            else if (attempts >= maxAttempts)
            {
                MessageBox.Show($"😞 Hakkınız bitti. Doğru kelime: {targetWord.ToUpper()}");
                btnSubmit.Enabled = false;

                for (int i = 0; i < targetWord.Length; i++)
                {
                    letterBoxes[i].Text = targetWord[i].ToString().ToUpper();
                    letterBoxes[i].BackColor = Color.Gray;
                    letterBoxes[i].ForeColor = Color.White;
                }
            }

            lblAttempts.Text = "Kalan Hak: " + (maxAttempts - attempts);
            txtGuess.Clear();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Bulmaca newGame = new Bulmaca();
            newGame.Show();
            this.Hide();
        }

      
    }
}