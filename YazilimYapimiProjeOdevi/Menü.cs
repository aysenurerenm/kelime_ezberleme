using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yazilimyapimiprojem;
using yazilimYapimiProjeOdevi;

namespace YazilimYapimiProjeOdevi
{
    public partial class Menü : Form
    {
        public Menü()
        {
            InitializeComponent();
        }

        private void btnKelimeler_Click(object sender, EventArgs e)
        {
            Kelimeler kelimeler= new Kelimeler();
            kelimeler.Show();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            Rapor rapor= new Rapor();
            rapor.Show();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            Ayar ayar=new Ayar();
            ayar.Show();
          
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Show();
        }

        private void btnBulmaca_Click(object sender, EventArgs e)
        {
            Bulmaca bulmaca= new Bulmaca();
            bulmaca.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
