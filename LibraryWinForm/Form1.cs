using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryWinForm
{
    public partial class Form1 : Form
    {
        LibraryAppEntities db = new LibraryAppEntities();
        public Form1()
        {
            InitializeComponent();
        }


        private void girisBtn_Click(object sender, EventArgs e)
        {
            string gelenAd = kullaniciAdi.Text;
            string parola = parolaGiris.Text;

            var personel = db.Personeller.Where(x => x.personal_ad.Equals(gelenAd) && x.personal_sifre.Equals(parola)).FirstOrDefault();

            if(personel == null)
            {
                MessageBox.Show("Kullancı adı veya şifre hatalı"); ;
            }
            else
            {
                MessageBox.Show("Basarili");
                IslemPaneli panel = new IslemPaneli();
                panel.Show();
                this.Hide();
            }
        }
    }
}
