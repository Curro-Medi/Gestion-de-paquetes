using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaPrincipal
{
    public partial class AltaSocio : Form
    {
        PantallaPrincipal pp;
        List<Socio> listasocios;

        public AltaSocio()
        {
            InitializeComponent();

        }

        public AltaSocio(List<Socio> socios, PantallaPrincipal pp)
        {
            InitializeComponent();
            this.pp = pp;
            socios = listasocios;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;

            for (int i = 0; i < listasocios.Count(); i++) {

                id++;
                
            }

            listasocios.Add(new Socio(textBox1.Text, textBox2.Text, id, null));

                pp.Show();
                this.Hide();
            
        }
    }
}
