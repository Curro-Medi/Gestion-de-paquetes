using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantallaPrincipal
{
    public class Socio
    {
        private String nombre;
        private String apellidos;
        private int id_socio;
        private List<Libro> libros;

        public Socio(string nombre, string apellidos, int id_socio, List<Libro> libros)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.id_socio = id_socio;
            this.libros = libros;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Id_socio { get => id_socio; set => id_socio = value; }
        public List<Libro> Libros { get => libros; set => libros = value; }

        public override string ToString()
        {
            return "Nombre: " + this.nombre + "   Apellido: " + this.apellidos;
        }



    }
}
