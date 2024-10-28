namespace LigaVentanas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lst1.Items.Clear();
             
            
            if (this.txt1.Text == "1" && File.Exists("partidosDisputados/EA_1.csv"))
            {
                using (StreamReader sr = File.OpenText("partidosDisputados/EA_1.csv"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        lst1.Items.Add(linea);
                    }
                }
            }
            else if (this.txt1.Text == "2" && File.Exists("partidosDisputados/EA_2.csv"))
            {
                using (StreamReader sr = File.OpenText("partidosDisputados/EA_2.csv"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        lst1.Items.Add(linea);
                    }
                }
            }
            else if (this.txt1.Text == "3" && File.Exists("partidosDisputados/EA_3.csv"))
            {
                using (StreamReader sr = File.OpenText("partidosDisputados/EA_3.csv"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        lst1.Items.Add(linea);
                    }
                }
            }
            else if (this.txt1.Text == "4" && File.Exists("partidosDisputados/EA_4.csv"))
            {
                using (StreamReader sr = File.OpenText("partidosDisputados/EA_4.csv"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        lst1.Items.Add(linea);
                    }
                }
            }
            else if (this.txt1.Text == "5" && File.Exists("partidosDisputados/EA_5.csv"))
            {
                using (StreamReader sr = File.OpenText("partidosDisputados/EA_5.csv"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        lst1.Items.Add(linea);
                    }
                }
            }
            else if (this.txt1.Text == "6" && File.Exists("partidosDisputados/EA_6.csv"))
            {
                using (StreamReader sr = File.OpenText("partidosDisputados/EA_6.csv"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        lst1.Items.Add(linea);
                    }
                }
            }
            else if (this.txt1.Text == "7" && File.Exists("partidosDisputados/EA_7.csv"))
            {
                using (StreamReader sr = File.OpenText("partidosDisputados/EA_7.csv"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        lst1.Items.Add(linea);
                    }
                }
            }
            else if (this.txt1.Text == "8" && File.Exists("partidosDisputados/EA_8.csv"))
            {
                using (StreamReader sr = File.OpenText("partidosDisputados/EA_8.csv"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        lst1.Items.Add(linea);
                    }
                }
            }
            else if (this.txt1.Text == "9" && File.Exists("partidosDisputados/EA_9.csv"))
            {
                using (StreamReader sr = File.OpenText("partidosDisputados/EA_9.csv"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        lst1.Items.Add(linea);
                    }
                }
            }
            else if (this.txt1.Text == "10" && File.Exists("partidosDisputados/EA_10.csv"))
            {
                using (StreamReader sr = File.OpenText("partidosDisputados/EA_10.csv"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        lst1.Items.Add(linea);
                    }
                }
            }
            else
            {
                MessageBox.Show("Numero de jornada inválido o archivo inexistente/no encontrado");
            }
        }
    }
}