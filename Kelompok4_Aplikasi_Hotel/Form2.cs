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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a, b, c, combo1, combo2;
            int harga, ppn, total, Lama;
            a = textBox1.Text;
            b = textBox2.Text;
            c = textBox3.Text;
            combo1 = comboBox1.Text;
            combo2 = comboBox2.Text;
            Lama = Convert.ToInt16(combo2);
            if (combo1.Equals("VIP"))
            {
                textBox4.Text = "Kamar Meawah,TV dan Hotspot";
                harga = 700000;
                ppn = 20000;
                total = (harga * Lama) + ppn;
                label15.Text = a;
                label16.Text = b;
                label17.Text = c;
                textBox5.Text = harga.ToString();
                textBox6.Text = ppn.ToString();
                textBox7.Text = total.ToString();
            }
            else if (combo1.Equals("STANDART"))
            {
                textBox4.Text = "Kamar Mewah dan TV";
                harga = 500000;
                ppn = 20000;
                total = (harga * Lama) + ppn;
                label15.Text = a;
                label16.Text = b;
                label17.Text = c;
                textBox5.Text = harga.ToString();
                textBox6.Text = ppn.ToString();
                textBox7.Text = total.ToString();
            }
            else if(combo1.Equals("HEMAT"))
            {
                textBox4.Text = "Kamar Mewah";
                harga = 300000;
                ppn = 20000;
                total = (harga * Lama) + ppn;
                label15.Text = a;
                label16.Text = b;
                label17.Text = c;
                textBox5.Text = harga.ToString();
                textBox6.Text = ppn.ToString();
                textBox7.Text = total.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
        }

        //merubah form help menjadi object & membuat prosedur close
        Help tolong; //object
        void tolong_close(object sender, FormClosedEventArgs a)
        {
            tolong = null;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (tolong == null)
            {
                tolong = new Help();
                tolong.FormClosed += new FormClosedEventHandler(tolong_close);
                tolong.Show();
            }
            else
            {
                tolong.Activate();
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }

}
