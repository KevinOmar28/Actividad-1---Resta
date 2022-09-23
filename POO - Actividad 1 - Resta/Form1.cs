namespace POO___Actividad_1___Resta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            Resta osuma = new Resta(int.Parse(Valor1.Text), int.Parse(Valor2.Text));
            Resultado.Text = osuma.restar().ToString();
        }
    }
}