using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantallaPrincipal
{
    public class Libro
    {
        private String iban;
        private String autor;
        private String titulo;

        public Libro(string iban, string autor, string titulo)
        {
            this.iban = iban;
            this.autor = autor;
            this.titulo = titulo;
        }

        public string Iban { get => iban; set => iban = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Titulo { get => titulo; set => titulo = value; }

        public override string ToString()
        {
            return "Iban: " + this.iban + "   Autor: " + this.autor + "   Titulo: " + this.titulo;
        }

    }
}
