namespace formulario
{
    public partial class Form1 : Form
    {
        private string tipo;
        public Form1(string tipoSelecionado)
        {
            InitializeComponent();
            tipo = tipoSelecionado;
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstrategico_Click(object sender, EventArgs e)
        {
            Form1 form = new
                Form1("Estratégico");
            form.Show();
            this.Hide();

        }
        private void btnTatico_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1("Tático");
            form.Show();
            this.Hide();
        }

        private void btnOperacional_Click(object sender, EventArgs e)
        {
            Form1 form = new
                Form1("Operacional");
            form.Show();
            this.Hide();

        }
    }
}
