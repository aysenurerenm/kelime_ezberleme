using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimYapimiProjeOdevi
{
    public partial class Kelimeler : Form
    {
        public Kelimeler()
        {
            InitializeComponent();
        }

        private void btnSözlük_Click(object sender, EventArgs e)
        {
            Sözlük sözlük=new Sözlük();
            sözlük.Show();
        }

        private void btnKelimeEkle_Click(object sender, EventArgs e)
        {
            KelimeEkle kelimeEkle=new KelimeEkle();
            kelimeEkle.Show();
        }
    }
}
