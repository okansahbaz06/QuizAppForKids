using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using System.Data.OleDb;

namespace QuestionsForKids
{
    public partial class OYBilenSorularForm : Form
    {
        public OYBilenSorularForm()
        {
            InitializeComponent();
        }

        public OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");
        public DataTable tablo = new DataTable();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public OleDbCommand kmt = new OleDbCommand();

        int sayac = 0;
        int puan = 0;
        int zaman = 31;

        private void puanArttır()
        {
            puan = puan + 10;
            scorelbl.Text = puan.ToString();
        }
        private void btnPasif ()
        {
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
        private void btnAktif()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }
        private void btnOrchid()
        {
            button1.BackColor = Color.DarkOrchid;
            button2.BackColor = Color.DarkOrchid;
            button3.BackColor = Color.DarkOrchid;
            button4.BackColor = Color.DarkOrchid;

        }
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            zaman = 31;
            btnOrchid();
            button5.Enabled = false;
            btnAktif();
            button5.Text = "SONRAKİ";
            sayac++;
            questionlbl.Text = sayac.ToString();
         
            baglan.Open();
            if (sayac == 1)
            {
                kmt = new OleDbCommand("Select * from soru1 order by rnd(-id*time()) ", baglan);

            }
            else if (sayac == 2)
            {
                kmt = new OleDbCommand("Select * from soru2 order by rnd(-id*time()) ", baglan);
            }
            else if (sayac == 3)
            {
                kmt = new OleDbCommand("Select * from soru3 order by rnd(-id*time()) ", baglan);
            }
            else if (sayac == 4)
            {
                kmt = new OleDbCommand("Select * from soru4 order by rnd(-id*time()) ", baglan);
            }
            else if (sayac == 5)
            {
                kmt = new OleDbCommand("Select * from soru5 order by rnd(-id*time()) ", baglan);
            }
            else if (sayac == 6)
            {
                kmt = new OleDbCommand("Select * from soru6 order by rnd(-id*time()) ", baglan);
            }
            else if (sayac == 7)
            {
                kmt = new OleDbCommand("Select * from soru7 order by rnd(-id*time()) ", baglan);
            }
            else if (sayac == 8)
            {
                kmt = new OleDbCommand("Select * from soru8 order by rnd(-id*time()) ", baglan);
            }
            else if (sayac == 9)
            {
                kmt = new OleDbCommand("Select * from soru9 order by rnd(-id*time()) ", baglan);
            }

            else if (sayac == 10)
            {
                button5.Text = "OYUN BİTTİ";
                button5.Enabled = false;
                kmt = new OleDbCommand("Select * from soru10 order by rnd(-id*time()) ", baglan);

            }
            else if (sayac == 11)
            {
                puan = 0;
                scorelbl.Text = puan.ToString();
                sayac = 0;
                questionlbl.Text = sayac.ToString();
                button5.Text = "BAŞTAN BAŞLA";
                button5.Enabled = true;
                kmt = new OleDbCommand("Select * from soru1 order by rnd(-id*time()) ", baglan);
                btnPasif();
                timer1.Enabled = false;
            }
            OleDbDataReader oku1 = kmt.ExecuteReader();
            oku1.Read();
            if (oku1.HasRows)
            {
                button1.Text = (oku1["a"].ToString());
                button2.Text = (oku1["b"].ToString());
                button3.Text = (oku1["c"].ToString());
                button4.Text = (oku1["d"].ToString());
                sorular.Text = (oku1["soru"].ToString());
                lbldogru.Text = (oku1["dogru"].ToString());
                baglan.Close();
            }


        }

        private void OYBilenSorularForm_Load(object sender, EventArgs e)
        {
            questionlbl.Text = sayac.ToString();
            btnPasif();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == lbldogru.Text)
            {
                puanArttır();
                button1.BackColor = Color.Green;
            }
            else
            {
                button1.BackColor = Color.Red;
            }
            button5.Enabled = true;
            btnPasif();

            timer1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == lbldogru.Text)
            {
                puanArttır();
                button2.BackColor = Color.Green;
            }
            else
            {
                button2.BackColor = Color.Red;
            }
            button5.Enabled = true;
            btnPasif();
            button2.ForeColor = Color.White;

            timer1.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == lbldogru.Text)
            {
                puanArttır();
                button3.BackColor = Color.Green;
            }
            else
            {
                button3.BackColor = Color.Red;
            }
            button5.Enabled = true;
            btnPasif();
            button3.ForeColor = Color.White;
            timer1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == lbldogru.Text)
            {
                puanArttır();
                button4.BackColor = Color.Green;
            }
            else
            {
                button4.BackColor = Color.Red;
            }
            button5.Enabled = true;
            btnPasif();
            button4.ForeColor = Color.White;

            timer1.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman - 1;
            timelbl.Text = zaman.ToString();

            if (zaman == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("ZAMAN DOLDU", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnPasif();
                button5.Enabled = true;
            }
        }


    }
}
