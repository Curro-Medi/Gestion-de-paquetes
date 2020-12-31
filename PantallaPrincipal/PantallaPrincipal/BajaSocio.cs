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
    public partial class BajaSocio : Form
    {
        PantallaPrincipal pp;
        List<Socio> socios;

        public BajaSocio()
        {
            InitializeComponent();
        }

        public BajaSocio(List<Socio> listasocios, PantallaPrincipal pp)
        {
            InitializeComponent();
            this.pp = pp;
            socios = listasocios;

            for (int i = 0; i < socios.Count(); i++)
            {
                listBox1.Items.Add(socios[i].ToString());
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();


            for (int i = 0; i < socios.Count(); i++)
            {

                if (socios[i].Nombre == textBox1.Text || socios[i].Apellidos == textBox1.Text)
                {

                    listBox1.Items.Add(socios[i].ToString());
                   
                }

            }
            if (textBox1.Text == "")
            {
                for (int i = 0; i < socios.Count(); i++)
                {
                    listBox1.Items.Add(socios[i].ToString());
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < socios.Count(); i++)
            {

                if (listBox1.SelectedItem.Equals(socios[i].ToString()))
                {
                    if(socios[i].Libros != null)
                    {
                        MessageBox.Show("Imposible eliminar persona, tiene libros asignados");
                    }
                    else
                    {
                        socios.Remove(socios[i]);
                    }
                    

                }

            }
           
        }
    }
}
