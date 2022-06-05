using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionsForKids
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void ogrencibtn_Click(object sender, EventArgs e)
        {
            OYBilenSorularForm oYBilenSorularForm = new OYBilenSorularForm();
            oYBilenSorularForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginForm lgn = new loginForm();
            lgn.Show();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cocukbtn_Click(object sender, EventArgs e)
        {
            OYBilmeyenSorular oYBilmeyen = new OYBilmeyenSorular();
            oYBilmeyen.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
