﻿using System;
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
    public partial class KullaniciListeForm : Form
    {
        public KullaniciListeForm()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            LibraryAppEntities db = new LibraryAppEntities();
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }
        private void KullaniciListeForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
