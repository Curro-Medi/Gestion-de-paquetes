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
    public partial class PantallaPrincipal : Form
    {

        List<Libro> libros = new List<Libro>();
        List<Socio> socios = new List<Socio>();

        public PantallaPrincipal()
        {
            InitializeComponent();
            libros.Add(new Libro("123", "Michael Robinson", "El diario de Greg 1"));
            libros.Add(new Libro("167", "Arnold Schwarzenegger", "Los Mercenarios 3"));
            libros.Add(new Libro("342", "Ansu Fati", "De adolescente a futbolista profesional"));
            libros.Add(new Libro("983", "Rafa Nadal", "No paro de ganar"));
            libros.Add(new Libro("457", "Manolo Lama", "Ay mi madre el bicho"));

            socios.Add(new Socio("Juan", "Melado Solo", 1, null));
            socios.Add(new Socio("Eugenia", "Fernandez Rios", 2, null));
            socios.Add(new Socio("Lionel", "Messi Gil", 3, null));
            socios.Add(new Socio("Oliver", "Torres Garcia", 4, null));
            socios.Add(new Socio("Jesus", "Navas Mendez", 5, null));



        }

        private void button4_Click(object sender, EventArgs e)
        {
            BajaSocio bajasocio = new BajaSocio(socios, this);
            this.Hide();
            bajasocio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaSocio altasocio = new AltaSocio(socios, this);
            this.Hide();
            altasocio.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
