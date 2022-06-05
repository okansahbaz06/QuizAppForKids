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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");
        public DataTable tablo = new DataTable();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public OleDbCommand kmt = new OleDbCommand();
        public string soruGrup;
        string secim = "1";
        string sorgu;
        int id;


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            comboBox1.Text = "Sorular 1";
            timer1.Start();
            //this.Location = new Point(450, 100);
            listele();
        }

        public void listele()
        {
            bag.Close();
            tablo.Clear();
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select id,soru,a,b,c,d,dogru From soru1", bag);
            comboBox1.Text = "Soru Grubu 1";

            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            bag.Close();
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //datagridview1'deki tüm satırı seç              
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Soru";
                //sütunlardaki textleri değiştirme
                dataGridView1.Columns[2].HeaderText = "A Şıkkı";
                dataGridView1.Columns[3].HeaderText = "B Şıkkı";
                dataGridView1.Columns[4].HeaderText = "C Şıkkı";
                dataGridView1.Columns[5].HeaderText = "D Şıkkı";
                dataGridView1.Columns[6].HeaderText = "Doğru Şık";

                dataGridView1.Columns[0].Width = 80;
                dataGridView1.Columns[1].Width = 120;
                //sütunların genişliğini belirleme
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[5].Width = 100;
                dataGridView1.Columns[6].Width = 100;
            }
            catch
            {
                ;
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != "")
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            //label9.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            //comboBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bag.Close();
            if (comboBox1.SelectedIndex == 0)
            {
                secim = "1";
                tablo.Clear();
                bag.Open();
                OleDbDataAdapter adtr = new OleDbDataAdapter("select id,soru,a,b,c,d,dogru From soru1", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                adtr.Dispose();
                bag.Close();
                try
                {
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    //datagridview1'deki tüm satırı seç              
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "Soru";
                    //sütunlardaki textleri değiştirme
                    dataGridView1.Columns[2].HeaderText = "A Şıkkı";
                    dataGridView1.Columns[3].HeaderText = "B Şıkkı";
                    dataGridView1.Columns[4].HeaderText = "C Şıkkı";
                    dataGridView1.Columns[5].HeaderText = "D Şıkkı";
                    dataGridView1.Columns[6].HeaderText = "Doğru Şık";

                    dataGridView1.Columns[0].Width = 80;
                    dataGridView1.Columns[1].Width = 120;
                    //sütunların genişliğini belirleme
                    dataGridView1.Columns[2].Width = 100;
                    dataGridView1.Columns[3].Width = 100;
                    dataGridView1.Columns[4].Width = 100;
                    dataGridView1.Columns[5].Width = 100;
                    dataGridView1.Columns[6].Width = 100;
                }
                catch
                {
                    ;
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                secim = "2";
                tablo.Clear();
                bag.Open();
                OleDbDataAdapter adtr = new OleDbDataAdapter("select id,soru,a,b,c,d,dogru From soru2", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                adtr.Dispose();
                bag.Close();
                try
                {
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    //datagridview1'deki tüm satırı seç              
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "Soru";
                    //sütunlardaki textleri değiştirme
                    dataGridView1.Columns[2].HeaderText = "A Şıkkı";
                    dataGridView1.Columns[3].HeaderText = "B Şıkkı";
                    dataGridView1.Columns[4].HeaderText = "C Şıkkı";
                    dataGridView1.Columns[5].HeaderText = "D Şıkkı";
                    dataGridView1.Columns[6].HeaderText = "Doğru Şık";

                    dataGridView1.Columns[0].Width = 80;
                    dataGridView1.Columns[1].Width = 120;
                    //sütunların genişliğini belirleme
                    dataGridView1.Columns[2].Width = 100;
                    dataGridView1.Columns[3].Width = 100;
                    dataGridView1.Columns[4].Width = 100;
                    dataGridView1.Columns[5].Width = 100;
                    dataGridView1.Columns[6].Width = 100;
                }
                catch
                {
                    ;
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                secim = "3";
                tablo.Clear();
                bag.Open();
                OleDbDataAdapter adtr = new OleDbDataAdapter("select id,soru,a,b,c,d,dogru From soru3", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                adtr.Dispose();
                bag.Close();
                try
                {
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    //datagridview1'deki tüm satırı seç              
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "Soru";
                    //sütunlardaki textleri değiştirme
                    dataGridView1.Columns[2].HeaderText = "A Şıkkı";
                    dataGridView1.Columns[3].HeaderText = "B Şıkkı";
                    dataGridView1.Columns[4].HeaderText = "C Şıkkı";
                    dataGridView1.Columns[5].HeaderText = "D Şıkkı";
                    dataGridView1.Columns[6].HeaderText = "Doğru Şık";

                    dataGridView1.Columns[0].Width = 80;
                    dataGridView1.Columns[1].Width = 120;
                    //sütunların genişliğini belirleme
                    dataGridView1.Columns[2].Width = 100;
                    dataGridView1.Columns[3].Width = 100;
                    dataGridView1.Columns[4].Width = 100;
                    dataGridView1.Columns[5].Width = 100;
                    dataGridView1.Columns[6].Width = 100;
                }
                catch
                {
                    ;
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                secim = "4";
                tablo.Clear();
                bag.Open();
                OleDbDataAdapter adtr = new OleDbDataAdapter("select id,soru,a,b,c,d,dogru From soru4", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                adtr.Dispose();
                bag.Close();
                try
                {
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    //datagridview1'deki tüm satırı seç              
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "Soru";
                    //sütunlardaki textleri değiştirme
                    dataGridView1.Columns[2].HeaderText = "A Şıkkı";
                    dataGridView1.Columns[3].HeaderText = "B Şıkkı";
                    dataGridView1.Columns[4].HeaderText = "C Şıkkı";
                    dataGridView1.Columns[5].HeaderText = "D Şıkkı";
                    dataGridView1.Columns[6].HeaderText = "Doğru Şık";

                    dataGridView1.Columns[0].Width = 80;
                    dataGridView1.Columns[1].Width = 120;
                    //sütunların genişliğini belirleme
                    dataGridView1.Columns[2].Width = 100;
                    dataGridView1.Columns[3].Width = 100;
                    dataGridView1.Columns[4].Width = 100;
                    dataGridView1.Columns[5].Width = 100;
                    dataGridView1.Columns[6].Width = 100;
                }
                catch
                {
                    ;
                }
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                secim = "5";
                tablo.Clear();
                bag.Open();
                OleDbDataAdapter adtr = new OleDbDataAdapter("select id,soru,a,b,c,d,dogru From soru5", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                adtr.Dispose();
                bag.Close();
                try
                {
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    //datagridview1'deki tüm satırı seç              
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "Soru";
                    //sütunlardaki textleri değiştirme
                    dataGridView1.Columns[2].HeaderText = "A Şıkkı";
                    dataGridView1.Columns[3].HeaderText = "B Şıkkı";
                    dataGridView1.Columns[4].HeaderText = "C Şıkkı";
                    dataGridView1.Columns[5].HeaderText = "D Şıkkı";
                    dataGridView1.Columns[6].HeaderText = "Doğru Şık";

                    dataGridView1.Columns[0].Width = 80;
                    dataGridView1.Columns[1].Width = 120;
                    //sütunların genişliğini belirleme
                    dataGridView1.Columns[2].Width = 100;
                    dataGridView1.Columns[3].Width = 100;
                    dataGridView1.Columns[4].Width = 100;
                    dataGridView1.Columns[5].Width = 100;
                    dataGridView1.Columns[6].Width = 100;
                }
                catch
                {
                    ;
                }
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                secim = "6";
                tablo.Clear();
                bag.Open();
                OleDbDataAdapter adtr = new OleDbDataAdapter("select id,soru,a,b,c,d,dogru From soru6", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                adtr.Dispose();
                bag.Close();
                try
                {
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    //datagridview1'deki tüm satırı seç              
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "Soru";
                    //sütunlardaki textleri değiştirme
                    dataGridView1.Columns[2].HeaderText = "A Şıkkı";
                    dataGridView1.Columns[3].HeaderText = "B Şıkkı";
                    dataGridView1.Columns[4].HeaderText = "C Şıkkı";
                    dataGridView1.Columns[5].HeaderText = "D Şıkkı";
                    dataGridView1.Columns[6].HeaderText = "Doğru Şık";

                    dataGridView1.Columns[0].Width = 80;
                    dataGridView1.Columns[1].Width = 120;
                    //sütunların genişliğini belirleme
                    dataGridView1.Columns[2].Width = 100;
                    dataGridView1.Columns[3].Width = 100;
                    dataGridView1.Columns[4].Width = 100;
                    dataGridView1.Columns[5].Width = 100;
                    dataGridView1.Columns[6].Width = 100;
                }
                catch
                {
                    ;
                }
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                secim = "7";
                tablo.Clear();
                bag.Open();
                OleDbDataAdapter adtr = new OleDbDataAdapter("select id,soru,a,b,c,d,dogru From soru7", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                adtr.Dispose();
                bag.Close();
                try
                {
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    //datagridview1'deki tüm satırı seç              
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "Soru";
                    //sütunlardaki textleri değiştirme
                    dataGridView1.Columns[2].HeaderText = "A Şıkkı";
                    dataGridView1.Columns[3].HeaderText = "B Şıkkı";
                    dataGridView1.Columns[4].HeaderText = "C Şıkkı";
                    dataGridView1.Columns[5].HeaderText = "D Şıkkı";
                    dataGridView1.Columns[6].HeaderText = "Doğru Şık";

                    dataGridView1.Columns[0].Width = 80;
                    dataGridView1.Columns[1].Width = 120;
                    //sütunların genişliğini belirleme
                    dataGridView1.Columns[2].Width = 100;
                    dataGridView1.Columns[3].Width = 100;
                    dataGridView1.Columns[4].Width = 100;
                    dataGridView1.Columns[5].Width = 100;
                    dataGridView1.Columns[6].Width = 100;
                }
                catch
                {
                    ;
                }
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                secim = "8";
                tablo.Clear();
                bag.Open();
                OleDbDataAdapter adtr = new OleDbDataAdapter("select id,soru,a,b,c,d,dogru From soru8", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                adtr.Dispose();
                bag.Close();
                try
                {
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    //datagridview1'deki tüm satırı seç              
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "Soru";
                    //sütunlardaki textleri değiştirme
                    dataGridView1.Columns[2].HeaderText = "A Şıkkı";
                    dataGridView1.Columns[3].HeaderText = "B Şıkkı";
                    dataGridView1.Columns[4].HeaderText = "C Şıkkı";
                    dataGridView1.Columns[5].HeaderText = "D Şıkkı";
                    dataGridView1.Columns[6].HeaderText = "Doğru Şık";

                    dataGridView1.Columns[0].Width = 80;
                    dataGridView1.Columns[1].Width = 120;
                    //sütunların genişliğini belirleme
                    dataGridView1.Columns[2].Width = 100;
                    dataGridView1.Columns[3].Width = 100;
                    dataGridView1.Columns[4].Width = 100;
                    dataGridView1.Columns[5].Width = 100;
                    dataGridView1.Columns[6].Width = 100;
                }
                catch
                {
                    ;
                }
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                secim = "9";
                tablo.Clear();
                bag.Open();
                OleDbDataAdapter adtr = new OleDbDataAdapter("select id,soru,a,b,c,d,dogru From soru9", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                adtr.Dispose();
                bag.Close();
                try
                {
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    //datagridview1'deki tüm satırı seç              
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "Soru";
                    //sütunlardaki textleri değiştirme
                    dataGridView1.Columns[2].HeaderText = "A Şıkkı";
                    dataGridView1.Columns[3].HeaderText = "B Şıkkı";
                    dataGridView1.Columns[4].HeaderText = "C Şıkkı";
                    dataGridView1.Columns[5].HeaderText = "D Şıkkı";
                    dataGridView1.Columns[6].HeaderText = "Doğru Şık";

                    dataGridView1.Columns[0].Width = 80;
                    dataGridView1.Columns[1].Width = 120;
                    //sütunların genişliğini belirleme
                    dataGridView1.Columns[2].Width = 100;
                    dataGridView1.Columns[3].Width = 100;
                    dataGridView1.Columns[4].Width = 100;
                    dataGridView1.Columns[5].Width = 100;
                    dataGridView1.Columns[6].Width = 100;
                }
                catch
                {
                    ;
                }
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                secim = "10";
                tablo.Clear();
                bag.Open();
                OleDbDataAdapter adtr = new OleDbDataAdapter("select id,soru,a,b,c,d,dogru From soru10", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                adtr.Dispose();
                bag.Close();
                try
                {
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    //datagridview1'deki tüm satırı seç              
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "Soru";
                    //sütunlardaki textleri değiştirme
                    dataGridView1.Columns[2].HeaderText = "A Şıkkı";
                    dataGridView1.Columns[3].HeaderText = "B Şıkkı";
                    dataGridView1.Columns[4].HeaderText = "C Şıkkı";
                    dataGridView1.Columns[5].HeaderText = "D Şıkkı";
                    dataGridView1.Columns[6].HeaderText = "Doğru Şık";

                    dataGridView1.Columns[0].Width = 80;
                    dataGridView1.Columns[1].Width = 120;
                    //sütunların genişliğini belirleme
                    dataGridView1.Columns[2].Width = 100;
                    dataGridView1.Columns[3].Width = 100;
                    dataGridView1.Columns[4].Width = 100;
                    dataGridView1.Columns[5].Width = 100;
                    dataGridView1.Columns[6].Width = 100;
                }
                catch
                {
                    ;
                }
            }

        }
        //create
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Ekleme Yapmadan Önce Soru Grubu Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (richTextBox1.Text.Trim() == "") errorProvider1.SetError(richTextBox1, "Boş geçilmez");
                    else errorProvider1.SetError(richTextBox1, "");
                    if (textBox2.Text.Trim() == "") errorProvider1.SetError(textBox2, "Boş geçilmez");
                    else errorProvider1.SetError(textBox2, "");
                    if (textBox3.Text.Trim() == "") errorProvider1.SetError(textBox3, "Boş geçilmez");
                    else errorProvider1.SetError(textBox3, "");
                    if (textBox4.Text.Trim() == "") errorProvider1.SetError(textBox4, "Boş geçilmez");
                    else errorProvider1.SetError(textBox4, "");
                    if (textBox5.Text.Trim() == "") errorProvider1.SetError(textBox5, "Boş geçilmez");
                    else errorProvider1.SetError(textBox5, "");
                    if (textBox6.Text.Trim() == "") errorProvider1.SetError(textBox6, "Boş geçilmez");
                    else errorProvider1.SetError(textBox6, "");

                    if (richTextBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && textBox4.Text.Trim() != "" && textBox5.Text.Trim() != "" && textBox6.Text.Trim() != "")
                    {
                        bag.Open();
                        kmt.Connection = bag;

                        if (comboBox1.SelectedIndex == 0)
                        {
                            kmt.CommandText = "INSERT INTO soru1(soru,a,b,c,d,dogru) VALUES ('" + richTextBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "') ";
                        }

                        else if (comboBox1.SelectedIndex == 1)
                        {
                            kmt.CommandText = "INSERT INTO soru2(soru,a,b,c,d,dogru) VALUES ('" + richTextBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "') ";
                        }
                        else if (comboBox1.SelectedIndex == 2)
                        {
                            kmt.CommandText = "INSERT INTO soru3(soru,a,b,c,d,dogru) VALUES ('" + richTextBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "') ";
                        }
                        else if (comboBox1.SelectedIndex == 3)
                        {
                            kmt.CommandText = "INSERT INTO soru4(soru,a,b,c,d,dogru) VALUES ('" + richTextBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "') ";
                        }
                        else if (comboBox1.SelectedIndex == 4)
                        {
                            kmt.CommandText = "INSERT INTO soru5(soru,a,b,c,d,dogru) VALUES ('" + richTextBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "') ";
                        }
                        else if (comboBox1.SelectedIndex == 5)
                        {
                            kmt.CommandText = "INSERT INTO soru6(soru,a,b,c,d,dogru) VALUES ('" + richTextBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "') ";
                        }
                        else if (comboBox1.SelectedIndex == 6)
                        {
                            kmt.CommandText = "INSERT INTO soru7(soru,a,b,c,d,dogru) VALUES ('" + richTextBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "') ";
                        }
                        else if (comboBox1.SelectedIndex == 7)
                        {
                            kmt.CommandText = "INSERT INTO soru8(soru,a,b,c,d,dogru) VALUES ('" + richTextBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "') ";
                        }
                        else if (comboBox1.SelectedIndex == 8)
                        {
                            kmt.CommandText = "INSERT INTO soru9(soru,a,b,c,d,dogru) VALUES ('" + richTextBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "') ";
                        }
                        else if (comboBox1.SelectedIndex == 9)
                        {
                            kmt.CommandText = "INSERT INTO soru10(soru,a,b,c,d,dogru) VALUES ('" + richTextBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "') ";
                        }


                        kmt.ExecuteNonQuery();
                        kmt.Dispose();
                        bag.Close();
                        for (int i = 0; i < this.Controls.Count; i++)
                        {
                            if (this.Controls[i] is TextBox) this.Controls[i].Text = "";
                        }
                        MessageBox.Show("Ekleme Başarılı !", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        richTextBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";

                        listele();

                    }

                }
                catch
                {
                    MessageBox.Show("Hata !");
                    bag.Close();
                }
            }

        }
        //delete
        private void button3_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Silme İşlemi Yapmadan Önce Soru Grubu Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DialogResult cevap;
                    cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cevap == DialogResult.Yes && dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() != "")
                    {
                        bag.Open();
                        kmt.Connection = bag;
                        if (secim == "1")
                        {
                            kmt.CommandText = "DELETE from soru1 WHERE soru='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "' ";
                        }

                        else if (secim == "2")
                        {
                            kmt.CommandText = "DELETE from soru2 WHERE soru='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "' ";
                        }
                        else if (secim == "3")
                        {
                            kmt.CommandText = "DELETE from soru3 WHERE soru='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "' ";
                        }
                        else if (secim == "4")
                        {
                            kmt.CommandText = "DELETE from soru4 WHERE soru='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "' ";
                        }
                        else if (secim == "5")
                        {
                            kmt.CommandText = "DELETE from soru5 WHERE soru='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "' ";
                        }
                        else if (secim == "6")
                        {
                            kmt.CommandText = "DELETE from soru6 WHERE soru='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "' ";
                        }
                        else if (secim == "7")
                        {
                            kmt.CommandText = "DELETE from soru7 WHERE soru='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "' ";
                        }
                        else if (secim == "8")
                        {
                            kmt.CommandText = "DELETE from soru8 WHERE soru='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "' ";
                        }
                        else if (secim == "9")
                        {
                            kmt.CommandText = "DELETE from soru9 WHERE soru='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "' ";
                        }
                        else if (secim == "10")
                        {
                            kmt.CommandText = "DELETE from soru10 WHERE soru='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "' ";
                        }

                        kmt.ExecuteNonQuery();
                        kmt.Dispose();
                        bag.Close();
                        listele();
                        MessageBox.Show("Silme Başarılı!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
                catch
                {
                    ;
                }
            }

        }
        //update
        private void button2_Click(object sender, EventArgs e)
        {
            bag.Close();
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Güncelleme İşlemi Yapmadan Önce Soru Grubu Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (richTextBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && textBox4.Text.Trim() != "" && textBox5.Text.Trim() != "" && textBox6.Text.Trim() != "")
                    {

                        if (secim == "1")
                        {
                            sorgu = "UPDATE soru1 SET soru='" + richTextBox1.Text + "', a='" + textBox2.Text + "',b='" + textBox3.Text + "',c='" + textBox4.Text + "',d='" + textBox5.Text + "',dogru='" + textBox6.Text + "' WHERE id= " + id;

                        }

                        else if (secim == "2")
                        {
                            sorgu = "UPDATE soru2 SET  soru='" + richTextBox1.Text + "', a='" + textBox2.Text + "',b='" + textBox3.Text + "',c='" + textBox4.Text + "',d='" + textBox5.Text + "',dogru='" + textBox6.Text + "' WHERE id= " + id;
                        }
                        else if (secim == "3")
                        {
                            sorgu = "UPDATE soru3 SET soru='" + richTextBox1.Text + "', a='" + textBox2.Text + "',b='" + textBox3.Text + "',c='" + textBox4.Text + "',d='" + textBox5.Text + "',dogru='" + textBox6.Text + "' WHERE id= " + id;
                        }
                        else if (secim == "4")
                        {
                            sorgu = "UPDATE soru4 SET soru='" + richTextBox1.Text + "', a='" + textBox2.Text + "',b='" + textBox3.Text + "',c='" + textBox4.Text + "',d='" + textBox5.Text + "',dogru='" + textBox6.Text + "' WHERE id= " + id;
                        }
                        else if (secim == "5")
                        {
                            sorgu = "UPDATE soru5 SET soru='" + richTextBox1.Text + "', a='" + textBox2.Text + "',b='" + textBox3.Text + "',c='" + textBox4.Text + "',d='" + textBox5.Text + "',dogru='" + textBox6.Text + "' WHERE id= " + id;
                        }
                        else if (secim == "6")
                        {
                            sorgu = "UPDATE soru6 SET soru='" + richTextBox1.Text + "', a='" + textBox2.Text + "',b='" + textBox3.Text + "',c='" + textBox4.Text + "',d='" + textBox5.Text + "',dogru='" + textBox6.Text + "' WHERE id= " + id;
                        }
                        else if (secim == "7")
                        {
                            sorgu = "UPDATE soru7 SET soru='" + richTextBox1.Text + "', a='" + textBox2.Text + "',b='" + textBox3.Text + "',c='" + textBox4.Text + "',d='" + textBox5.Text + "',dogru='" + textBox6.Text + "' WHERE id= " + id;
                        }
                        else if (secim == "8")
                        {
                            sorgu = "UPDATE soru8 SET soru='" + richTextBox1.Text + "', a='" + textBox2.Text + "',b='" + textBox3.Text + "',c='" + textBox4.Text + "',d='" + textBox5.Text + "',dogru='" + textBox6.Text + "' WHERE id= " + id;
                        }
                        else if (secim == "9")
                        {
                            sorgu = "UPDATE soru9 SET soru='" + richTextBox1.Text + "', a='" + textBox2.Text + "',b='" + textBox3.Text + "',c='" + textBox4.Text + "',d='" + textBox5.Text + "',dogru='" + textBox6.Text + "' WHERE id= " + id;
                        }
                        else if (secim == "10")
                        {
                            sorgu = "UPDATE soru10 SET soru='" + richTextBox1.Text + "', a='" + textBox2.Text + "',b='" + textBox3.Text + "',c='" + textBox4.Text + "',d='" + textBox5.Text + "',dogru='" + textBox6.Text + "' WHERE id= " + id;
                        }

                        OleDbCommand kmt = new OleDbCommand(sorgu, bag);
                        bag.Open();
                        kmt.ExecuteNonQuery();
                        kmt.Dispose();
                        bag.Close();
                        listele();
                        MessageBox.Show("Güncelleme İşlemi Tamamlandı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Boş Alan Bırakmayınız !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception h)
                { MessageBox.Show(h.Message); }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            label8.Text = "Tarih :" + bugun.ToString();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {



        }

    }

}
