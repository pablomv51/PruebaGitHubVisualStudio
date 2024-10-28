namespace VentanaMultiple
{
    public partial class Form1 : Form
    {
        private Form2 f2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //comprobar que form2 no esté abierto
            if(f2 == null || f2.IsDisposed)
            {
                //instanciar
                f2 = new Form2();
                //suscribirse al evento
                f2.OnDataSent += recepcionDatosForm2;
                f2.Show();
            }
            else
            {
                f2.BringToFront();
            }
        }
        private void recepcionDatosForm2 (string d)
        {
            this.label1.Text = "Datos recibidos: " + d;
        }
    }
}