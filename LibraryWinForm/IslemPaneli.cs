using LibraryWinForm.Kayit;
using LibraryWinForm.Kaynak;
using LibraryWinForm.Kullanici;
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
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }
        LibraryAppEntities db = new LibraryAppEntities();
        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            ekleKullanici.Visible = false;
            guncelleKullanici.Visible = false;
            silKullanici.Visible=false;

            ekleKaynakBtn.Visible = false;
            guncelleKaynakBtn.Visible=false;
            silKaynakBtn.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ekleKullanici.Visible == false)
            {
                ekleKullanici.Visible = true;
                guncelleKullanici.Visible = true;
                silKullanici.Visible = true;
            }
            else
            {
                ekleKullanici.Visible = false;
                guncelleKullanici.Visible = false;
                silKullanici.Visible = false;
            }
            KullaniciListeForm kListeForm = new KullaniciListeForm();
            kListeForm.MdiParent= this;
            kListeForm.Show();

        }

        private void ekleKullanici_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm ekleForm = new KullaniciEkleForm();
            ekleForm.MdiParent= this;
            ekleForm.Show();
        }

        private void silKullanici_Click(object sender, EventArgs e)
        {
            KullaniciSilForm kSil = new KullaniciSilForm();
            kSil.MdiParent= this;
            kSil.Show();
        }

        private void guncelleKullanici_Click(object sender, EventArgs e)
        {
            KullaniciGuncelleForm kGuncelle = new KullaniciGuncelleForm();
            kGuncelle.MdiParent= this;
            kGuncelle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(ekleKaynakBtn.Visible == false )
            {
                ekleKaynakBtn.Visible = true;
                guncelleKaynakBtn.Visible = true;
                silKaynakBtn.Visible = true;
            }
            else
            {
                ekleKaynakBtn.Visible = false;
                guncelleKaynakBtn.Visible = false;
                silKaynakBtn.Visible = false;
            }

            KaynakListeForm kListe = new KaynakListeForm();
            kListe.MdiParent= this;
            kListe.Show(); 
        }

        private void ekleKaynakBtn_Click(object sender, EventArgs e)
        {
            KaynakEkleForm kaynakEkle = new KaynakEkleForm();
            kaynakEkle.MdiParent= this;
            kaynakEkle.Show();
        }

        private void silKaynakBtn_Click(object sender, EventArgs e)
        {
            KaynakSilForm kSil = new KaynakSilForm();
            kSil.MdiParent= this;
            kSil.Show();
        }

        private void guncelleKaynakBtn_Click(object sender, EventArgs e)
        {
            KaynakGuncelleForm kaynakGuncelle = new KaynakGuncelleForm();
            kaynakGuncelle.MdiParent= this;
            kaynakGuncelle.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OduncVerForm odunc = new OduncVerForm();
            odunc.MdiParent= this;
            odunc.Show();
        }
    }
}
