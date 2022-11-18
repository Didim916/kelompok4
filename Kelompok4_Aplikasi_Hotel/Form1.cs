using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelompok4_Aplikasi_Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string akses = "kelompok4";
            if (this.user.Text == akses && this.pass.Text == akses)
            {
                MessageBox.Show("Selamat login success");
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                f2 = null;
                this.Show();
            }
            else
            {
                MessageBox.Show("Maaf Password Anda Salah");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            user.Text = "";
            pass.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
