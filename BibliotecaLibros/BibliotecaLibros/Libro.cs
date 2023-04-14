using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLibros
{               // Declaramos una clase Libro con dos atributos string, que son los que vamos a pedir en la aplicación. Una vez declarados, importamos la clase Libro mediante "using" a program.cs.
    public class Libro
    {
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Anno { get; set; }

        public Libro(string titulo, string autor, string anno)
        {
            Titulo = titulo;
            Autor = autor;
            Anno = anno;
        }
    }
}
