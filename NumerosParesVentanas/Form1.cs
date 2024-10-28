namespace NumerosParesVentanas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = File.OpenText(ofd.FileName))
                {
                    string numero;
                    while ((numero = sr.ReadLine()) != null)
                    {
                        if (int.TryParse(numero, out int num))
                        {
                            if (num % 2 == 0)
                            {
                                using StreamWriter sw = new StreamWriter("pares.txt", true);
                                {
                                    sw.WriteLine(numero);
                                }
                            }

                        }
                        {

                        }
                    }
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lst1.Items.Clear();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                using (StreamReader sr = File.OpenText(ofd.FileName))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        lst1.Items.Add(linea);
                    }
                }
            }
        }
    }
}
