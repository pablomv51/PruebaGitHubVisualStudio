namespace CalculadoraEnVentana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double x;
        double y;
        char operacion;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtresultados.Text = txtresultados.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtresultados.Text = txtresultados.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtresultados.Text = txtresultados.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtresultados.Text = txtresultados.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtresultados.Text = txtresultados.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtresultados.Text = txtresultados.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtresultados.Text = txtresultados.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtresultados.Text = txtresultados.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtresultados.Text = txtresultados.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtresultados.Text = txtresultados.Text + "0";
        }
        private void btncoma_Click(object sender, EventArgs e)
        {
            txtresultados.Text = txtresultados.Text + ",";
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtresultados.ResetText();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(txtresultados.Text);
            txtresultados.ResetText();
            operacion = '+';
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtresultados.Text);
            txtresultados.ResetText();
            operacion = '-';
        }

        private void btnmultiplica_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtresultados.Text);
            txtresultados.ResetText();
            operacion = '*';
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtresultados.Text);
            txtresultados.ResetText();
            operacion = '/';
        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(txtresultados.Text);
            if (operacion == '+')
            {
                double resultado = x + y;
                txtresultados.Text = resultado.ToString();
            }
            else if (operacion == '-')
            {
                double resultado = x - y;
                txtresultados.Text = resultado.ToString();
            }
            else if (operacion == '*')
            {
                double resultado = x * y;
                txtresultados.Text = resultado.ToString();
            }
            else { 
                double resultado = x / y;
                txtresultados.Text = resultado.ToString();
            }
      
        }

    }
}