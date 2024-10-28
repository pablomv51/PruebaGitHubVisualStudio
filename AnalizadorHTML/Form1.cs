using CsvHelper;


namespace AnalizadorHTML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string fichero = "fichero.csv";
            using(StreamReader sr = new StreamReader(fichero))
            {
                string? linea;
                while((linea = sr.ReadLine()) != null){
                    //dividir por
                    var campos = linea.Split(';');
                    //mostrar cada campo
                    foreach (var campo in campos)
                    {
                        this.lbl1.Text += campo + " ";
                    }
                    this.lbl1.Text += System.Environment.NewLine;
                }
            }

     
        }
        public class Persona
        {
            public string Nombre { get; set; }

            public string Edad { get; set; }

            public string Profesion { get; set; }
        }

    }
}