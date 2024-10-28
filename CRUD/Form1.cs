namespace CRUD
{
    public partial class Form1 : Form
    {

        private FileHelper fileHelper = new FileHelper();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            var persona = new Persona()
            {
                DNI = this.txt1.Text,
                Name = this.txt2.Text,
                Edad = int.Parse(this.txt3.Text)
            };
            fileHelper.Create(persona);
            this.CargaDatos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargaDatos();
        }

        private void CargaDatos()
        {
            var personas = fileHelper.ReadAll();
            this.GridViewPersonas.DataSource = personas;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            var persona = new Persona()
            {
                DNI = this.txt1.Text,
                Name = this.txt2.Text,
                Edad = int.Parse(this.txt3.Text)
            };
            fileHelper.Update(persona);
            this.CargaDatos();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
           fileHelper.Delete(this.txt1.Text);
            this.CargaDatos();
        }

        private void GridViewPersonas_SelectionChanged(object sender, EventArgs e)
        {
            if (GridViewPersonas.CurrentRow != null)
            {
                this.txt1.Text =
                    this.GridViewPersonas.CurrentRow.Cells["DNI"].Value.ToString();
                this.txt2.Text =
                    this.GridViewPersonas.CurrentRow.Cells["Name"].Value.ToString();
                this.txt3.Text =
                    this.GridViewPersonas.CurrentRow.Cells["Edad"].Value.ToString();
            }
        }
    }
}