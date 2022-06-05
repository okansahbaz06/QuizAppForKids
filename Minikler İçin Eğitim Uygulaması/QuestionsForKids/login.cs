using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuestionsForKids
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show(" Kullanıcı Adı ve Şifre Boş Geçilemez ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(textBox1.Text == "admin" && textBox2.Text=="123")
                {
                    Form2 frm = new Form2();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(" Kullanıcı Adı veya Şifre Yanlış ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Text = "";

                }
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
