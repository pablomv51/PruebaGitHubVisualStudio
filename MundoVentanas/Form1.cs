namespace MundoVentanas
{
    public partial class Form1 : Form
    {

        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Text = "Me has clickado";
        }

        private void button2_Click(object sender, MouseEventArgs e)
        {
           
            i++;
            button2.Text = i.ToString();
                

            }
        }
    }
