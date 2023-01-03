using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryWinForm.Kaynak
{
    public partial class KaynakEkleForm : Form
    {
        public KaynakEkleForm()
        {
            InitializeComponent();
        }

        LibraryAppEntities db = new LibraryAppEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            Kaynaklar kaynaklar = new Kaynaklar();

            kaynaklar.kaynak_ad = kaynakAdText.Text;
            kaynaklar.kaynak_yazar = kaynakYazarText.Text;
            kaynaklar.kaynak_yayinci = kaynakYayinEviText.Text;
            kaynaklar.kaynak_sayfasayisi = Convert.ToInt16(kaynakSayfaSayisiText.Text);
            kaynaklar.kaynak_basimtarigi = kaynakBasimTarihiText.Value;

            db.Kaynaklar.Add(kaynaklar);
            db.SaveChanges();

            var kListe = db.Kaynaklar.ToList();
            dataGridView1.DataSource= kListe.ToList(); 
        }
    }
}
