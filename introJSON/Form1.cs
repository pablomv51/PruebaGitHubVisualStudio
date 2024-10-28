using System.Text.Json;
namespace introJSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //serializar es transformar un objeto en JSON
            //crear un objeto persona:
            persona persona = new persona { Nombre = "Jhon", edad = 19 };
            string cadenaJSON = JsonSerializer.Serialize(persona, new JsonSerializerOptions { WriteIndented = true });
            this.lbl1.Text = cadenaJSON;
            {
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //deserializar es transformar un JSON en algo (ej: objeto)
            string cadenaJson = "{\"Nombre\":\"Jhon\",\"Edad\":19}";
            persona persona = JsonSerializer.Deserialize<persona>(cadenaJson);
            this.lbl1.Text = $"Nombre: {persona.Nombre},Edad: { persona.edad}";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            persona p = new persona { Nombre = "Cristo", edad = 18 };
            string cadenaJson = JsonSerializer.Serialize(p);
            using (StreamWriter sw = new StreamWriter("persona.json"))
            {
                sw.Write(cadenaJson);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("persona.json"))
            {
                string cadenaJson = sr.ReadToEnd();
                persona persona = JsonSerializer.Deserialize<persona>(cadenaJson);
                this.lbl1.Text = $"Nombre: {persona.Nombre}, Edad: {persona.edad}";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("persona.json"))
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
