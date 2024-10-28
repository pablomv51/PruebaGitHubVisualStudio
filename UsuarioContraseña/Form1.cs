namespace UsuarioContraseña
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido " + textBox1.Text);
        }
    }
}