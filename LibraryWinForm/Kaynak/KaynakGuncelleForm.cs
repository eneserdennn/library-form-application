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
    public partial class KaynakGuncelleForm : Form
    {
        public KaynakGuncelleForm()
        {
            InitializeComponent();
        }

        LibraryAppEntities db = new LibraryAppEntities();
        private void KaynakGuncelleForm_Load(object sender, EventArgs e)
        {
            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            kaynakAdText.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kaynakYazarText.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            kaynakYayinEviText.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            kaynakSayfaSayisiText.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value);
            kaynakBasimTarihiText.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenKaynak = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value); 
            var guncellenecekKaynak = db.Kaynaklar.Where(x => x.kaynak_id== secilenKaynak).FirstOrDefault();
            guncellenecekKaynak.kaynak_ad = kaynakAdText.Text;
            guncellenecekKaynak.kaynak_yazar = kaynakYazarText.Text;
            guncellenecekKaynak.kaynak_yayinci = kaynakYayinEviText.Text;
            guncellenecekKaynak.kaynak_sayfasayisi = Convert.ToInt16(kaynakSayfaSayisiText.Value);
            guncellenecekKaynak.kaynak_basimtarigi = Convert.ToDateTime(kaynakBasimTarihiText.Value);
            db.SaveChanges();

            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
        }
    }
}