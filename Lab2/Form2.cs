using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {
        private double _cena = 0.0;
        private double cena_dysku = 0.0;
        private double cena_karty = 0.0;
        public Form2()
        {
            InitializeComponent();
        }

        public double Get_Cena_form2()
        {
            return _cena;
        }

        public void Set_Cena_form2(double cena)
        {
            _cena = cena;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _cena = _cena - cena_dysku;
            _cena += 169.99;
            cena_dysku = 169.99;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "RTX 3060")
            {
                _cena = _cena - cena_karty;
                _cena += 1769.99;
                cena_karty = 1769.99;
            }
            else if(comboBox1.SelectedItem == "RTX 4090")
            {
                _cena = _cena - cena_karty;
                _cena += 10690.99;
                cena_karty = 10690.99;
            }
            else if(comboBox1.SelectedItem == "GTX 1050Ti")
            {
                _cena = _cena - cena_karty;
                _cena += 934.27;
                cena_karty = 934.27;
            }
            else if(comboBox1.SelectedItem == "RTX 2070")
            {
                _cena = _cena - cena_karty;
                _cena += 1449.99;
                cena_karty = 1449.99;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                _cena += 129.99;
            }
            else
            {
                _cena -= 129.99;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            _cena = _cena - cena_dysku;
            _cena += 599.99;
            cena_dysku = 599.99;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _cena = _cena - cena_dysku;
            _cena += 250.0;
            cena_dysku = 250.0;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            _cena = _cena - cena_dysku;
            _cena += 349.0;
            cena_dysku = 349.0;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                _cena += 40.99;
            }
            else
            {
                _cena -= 40.99;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                _cena += 59.99;
            }
            else
            {
                _cena -= 59.99;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            {
                _cena += 148.99;
            }
            else
            {
                _cena -= 148.99;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _cena = Math.Round(_cena, 2);
            label1.Text = _cena.ToString();
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }
    }

}
