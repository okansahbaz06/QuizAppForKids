using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuestionsForKids
{
    public partial class OYBilmeyenSorular : Form
    {
        public OYBilmeyenSorular()
        {
            InitializeComponent();
        }

        public OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");
        public DataTable tablo = new DataTable();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public OleDbCommand kmt = new OleDbCommand();

        int sayac = 0;
        int puan = 0;
        int zaman = 61;

        private void puanArttır()
        {
            puan = puan + 10;
            lblPuan.Text = puan.ToString();
        }

        private void btnPasif()
        {
            btnBasla.Enabled = true;
            pbA.Enabled = false;
            pbB.Enabled = false;
            pbC.Enabled = false;
            pbD.Enabled = false;
        }

        private void btnAktif()
        {
            pbA.Enabled = true;
            pbB.Enabled = true;
            pbC.Enabled = true;
            pbD.Enabled = true;
        }

        private void OYBilmeyenSorular_Load(object sender, EventArgs e)
        {
            lblSoru.Text = sayac.ToString();
            btnPasif();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            zaman = 61;
            btnBasla.Enabled = false;
            btnAktif();
            btnBasla.Text = "SONRAKİ";
            sayac++;
            lblSoru.Text = sayac.ToString();
            baglan.Open();
            if (sayac == 1)
            {
                kmt = new OleDbCommand("Select * from rsoru1 order by rnd(-id*time()) ", baglan);

            }
            else if (sayac == 2)
            {
                
                kmt = new OleDbCommand("Select * from rsoru2 order by rnd(-id*time()) ", baglan);
            }
            else if (sayac == 3)
            {

                kmt = new OleDbCommand("Select * from rsoru3 order by rnd(-id*time()) ", baglan);
            }
            else if (sayac == 4)
            {

                kmt = new OleDbCommand("Select * from rsoru4 order by rnd(-id*time()) ", baglan);
            }
            else if (sayac == 5)
            {
                btnBasla.Text = "OYUN BİTTİ";
                btnBasla.Enabled = false;
                kmt = new OleDbCommand("Select * from rsoru5 order by rnd(-id*time()) ", baglan);
            }
            else if (sayac == 6)
            {
                puan = 0;
                lblPuan.Text = puan.ToString();
                sayac = 0;
                lblSoru.Text = sayac.ToString();
                btnBasla.Text = "BAŞTAN BAŞLA";
                btnBasla.Enabled = true;
                kmt = new OleDbCommand("Select * from rsoru1 order by rnd(-id*time()) ", baglan);
                btnPasif();
                timer1.Enabled = false;
            }

            OleDbDataReader oku1 = kmt.ExecuteReader();
            oku1.Read();
            if (oku1.HasRows)
            {
                pbA.ImageLocation = (oku1["a"].ToString());
                pbB.ImageLocation = (oku1["b"].ToString());
                pbC.ImageLocation = (oku1["c"].ToString());
                pbD.ImageLocation = (oku1["d"].ToString());
                pbSoru.ImageLocation = (oku1["soru"].ToString());
                lblDogru.Text = (oku1["dogru"].ToString());
                baglan.Close();
            }
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman - 1;
            lblZaman.Text = zaman.ToString();

            if (zaman == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("ZAMAN DOLDU", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnPasif();
                btnBasla.Enabled = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pbA.ImageLocation == lblDogru.Text)
            {
                puanArttır();

            }
            btnBasla.Enabled = true;
            btnPasif();
            timer1.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pbB.ImageLocation == lblDogru.Text)
            {
                puanArttır();

            }
            btnBasla.Enabled = true;
            btnPasif();
            timer1.Enabled = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pbC.ImageLocation == lblDogru.Text)
            {
                puanArttır();

            }
            btnBasla.Enabled = true;
            btnPasif();
            timer1.Enabled = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pbD.ImageLocation == lblDogru.Text)
            {
                puanArttır();

            }
            btnBasla.Enabled = true;
            btnPasif();
            timer1.Enabled = false;
        }
    }
}
