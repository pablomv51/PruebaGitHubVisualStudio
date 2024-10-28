using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaMultiple
{
    public partial class Form2 : Form
    {
        //Definir un delegado y un evento para enviar datos a Form1
        public delegate void EnviarDatos(string dato);
        public event EnviarDatos OnDataSent;
        public Form2()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //verficar que el evento tenga suscripciones
            if (OnDataSent != null)
            {
                OnDataSent(this.txt1.Text);
            }
            this.Close();
        }

    }
}
