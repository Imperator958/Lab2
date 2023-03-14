using static System.Windows.Forms.AxHost;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public double cena = 0.0;
        double cena_form2 = 0.0;
        double cena_form3 = 0.0;
        bool isActive_form2 = false;
        bool isActive_form3 = false;

        Form2 form2 = new Form2();
        Form3 form3 = new Form3();

        public void SetCena(double _cena)
        {
            cena += _cena;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            isActive_form2 = true;
            try
            {
                form2.Set_Cena_form2(cena);
                form2.Show();
            }
            catch(System.ObjectDisposedException)
            {
                MessageBox.Show("Ju¿ dodano komputer!");
            }
        }

        private void Monitor_Click(object sender, EventArgs e)
        {
            isActive_form3 = true;
            try
            {
                form3.Set_Cena_form3(cena);
                form3.Show();
            }
            catch (System.ObjectDisposedException)
            {
                MessageBox.Show("Ju¿ dodano monitor!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cena = Math.Round(cena, 2);
            label1.Text = cena.ToString();
            if (form2.Get_Cena_form2() != 0)
            {
                cena_form2 = form2.Get_Cena_form2();
            }
            if(form3.Get_Cena_form3() != 0)
            {
                cena_form3 = form3.Get_Cena_form3();
            }
            if (Application.OpenForms.OfType<Form2>().Count() != 1 && isActive_form2 == true)
            {
                cena = cena_form2;
                isActive_form2 = false;
            }
            if (Application.OpenForms.OfType<Form3>().Count() != 1 && isActive_form3 == true)
            {
                cena = cena_form3;
                isActive_form3 = false;
            }
        }
    }
}