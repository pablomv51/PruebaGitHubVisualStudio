namespace FicheroProvincias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = File.OpenText(ofd.FileName))
                {
                    string provincia;
                    while ((provincia = sr.ReadLine()) != null)
                    {
                        cmb.Items.Add(provincia);
                    }
                }
            }
        }
    }
}

