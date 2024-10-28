namespace CRUD_NBA
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
                var equipo = new Equipo()
                {
                    Nombre = this.txt1.Text,
                    Conferencia = this.txt2.Text,
                    Estado = this.txt3.Text,
                    Posicion = int.Parse(this.txt4.Text),
                    Jugadores_plantilla = int.Parse(this.txt5.Text),
                    Titulos = int.Parse(this.txt6.Text),
                    Presupuesto = int.Parse(this.txt7.Text)
                };
                fileHelper.Create(equipo);
                this.CargaDatos();
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                CargaDatos();
            }


        private BindingSource bindingSource = new BindingSource();

        private void CargaDatos()
        {
            var equipos = fileHelper.ReadAll();
            bindingSource.DataSource = equipos;
            this.GridViewEquipos.DataSource = bindingSource;
            this.GridViewEquipos.Refresh();  //Refrescamos para evitar errores aquí
        }


            private void GridViewEquipos_SelectionChanged(object sender, EventArgs e)
            {
                if (GridViewEquipos.CurrentRow != null)
                {
                    this.txt1.Text =
                        this.GridViewEquipos.CurrentRow.Cells["Nombre"].Value.ToString();
                    this.txt2.Text =
                        this.GridViewEquipos.CurrentRow.Cells["Conferencia"].Value.ToString();
                    this.txt3.Text =
                        this.GridViewEquipos.CurrentRow.Cells["Estado"].Value.ToString();
                    this.txt4.Text =
                        this.GridViewEquipos.CurrentRow.Cells["Posición"].Value.ToString();
                    this.txt5.Text =
                        this.GridViewEquipos.CurrentRow.Cells["Jugadores Plantilla"].Value.ToString();
                    this.txt6.Text =
                        this.GridViewEquipos.CurrentRow.Cells["Títulos"].Value.ToString();
                    this.txt7.Text =
                        this.GridViewEquipos.CurrentRow.Cells["Presupuesto"].Value.ToString();
            }
            }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            var equipo = new Equipo()
            {
                Nombre = this.txt1.Text,
                Conferencia = this.txt2.Text,
                Estado = this.txt3.Text,
                Posicion = int.Parse(this.txt4.Text),
                Jugadores_plantilla = int.Parse(this.txt5.Text),
                Titulos = int.Parse(this.txt6.Text),
                Presupuesto = int.Parse(this.txt7.Text)
            };
            fileHelper.Update(equipo);
            this.CargaDatos();
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            fileHelper.Delete(this.txt1.Text);
            this.CargaDatos();
        }
    }
    }