namespace Lab2
{
    public partial class Form1 : Form
    {
        public double cena = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Monitor_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cena = Math.Round(cena, 2);
            label1.Text = cena.ToString();
        }
    }
}