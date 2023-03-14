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
    public partial class Form3 : Form
    {
        double _cena;
        public void Set_Cena_form3(double cena)
        {
            _cena = cena;
        }

        public double Get_Cena_form3()
        {
            return _cena;
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Typ", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("Rozmiar", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Cena", 100, HorizontalAlignment.Center);

            Dodaj("LG UltraGear", "28''", "869,99");
            Dodaj("IIyama G-Master", "23''", "1235,99");
            Dodaj("HP X24ih-gamingowy", "24,8''", "1499,99");
            Dodaj("Lenovo L24e-30", "24,8''", "2599,99");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Dodaj(string Typ, string rozmiar, string cena_monitora)
        {
            ListViewItem autoTyp = new ListViewItem(new[] { Typ, rozmiar, cena_monitora });
            listView1.Items.Add(autoTyp);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Selected)
                {
                    _cena += Convert.ToDouble(item.SubItems[2].Text);
                    label1.Text = _cena.ToString();
                    _cena = Math.Round(_cena, 2);
                }
            }
        }
    }
}
