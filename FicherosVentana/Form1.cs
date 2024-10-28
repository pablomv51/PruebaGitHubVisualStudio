namespace FicherosVentana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(this.txtbox1.Text))
            {
                StreamWriter sw = File.CreateText(txtbox1.Text); //El fichero se guarda en la carpeta bin.
                sw.WriteLine("Me llamo Pablo");
                sw.Close();
            }
        }

        private void btncarpeta_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(this.txtBox2.Text))
            {
                Directory.CreateDirectory(this.txtBox2.Text);

            }
        }

        private void btnmover_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.txtbox1.Text) && Directory.Exists(this.txtBox2.Text))
            {
                File.Move(this.txtbox1.Text, this.txtBox2.Text + "/" + this.txtbox1.Text);
            }
        }

        private void btnBorrarFichero_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.txtBox3.Text))
            {
                File.Delete(this.txtBox3.Text);
            }
        }

        private void btnBorrarCarpeta_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(this.txtBox4.Text))
            {
               Directory.Delete(this.txtBox4.Text,true); //Borra recursivamente, da igual que haya ficheros o subdirectorios, ponemos true porque en realidad sería recursive:true.
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            lst1.Items.Clear();
            if (File.Exists(this.txtBox5.Text))
            {
                using (StreamReader sr = File.OpenText(this.txtBox5.Text))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        lst1.Items.Add(linea);
                    }
                }
                
            }
        }


        private void btnAñadir_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(this.txtBox6.Text,true)) //para añadir en vez de sobreescribir el archivo.
            {
                sw.WriteLine(this.txtBox7.Text);
            }
        }

    }
}
