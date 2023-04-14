using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaLibros;

namespace BibliotecaLibros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos un array llamado libros de la clase Libro y también creamos una variable int numLibros ( es la variable que muestra los libros en el array y que inicializamos en 0).
            Libro[] libros = new Libro[1000];
            int numLibros = 0;

            bool salir = false;
            while (!salir)
            { // Declaramos la variable opción con un int para poder seleccionar correctamente el paso que queremos seguir. Se controla el error de excepciones con try catch.
                int opcion;
                try
                {
                    Console.WriteLine("==== Biblioteca ====");
                    Console.WriteLine("1. Añadir libro");
                    Console.WriteLine("2. Ver libros");
                    Console.WriteLine("3. Borrar libro");
                    Console.WriteLine("4. Salir");
                    Console.Write("Elige una opción : ");

                    opcion = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Opción inválida.");
                    continue;
                }
                // Una vez introducido el valor de la variable opcion por parte del usuario, entra en el Switch para seleccionar el caso que le corresponda.
                switch(opcion)
                {
                    case 1: //Este bucle primero comprueba que el array no esta lleno (Si el numero de libros que hay es mayor o igual que la longitud del array libros, no añadirá nada).
                    if ( numLibros >= libros.Length)
                        {
                            Console.WriteLine("La biblioteca está llena.");
                            break;
                        }
                        //Una vez comprobado lo anterior, nos pedirá los atributos declarados en la clase Libro para poder crear un objeto dentro del array.
                        Console.WriteLine("Introduce el título del libro: ");
                        string titulo = Console.ReadLine();

                        Console.WriteLine("Introduce el autor del libro: ");
                        string autor = Console.ReadLine();

                        Console.WriteLine("Introduce el año de publicación");
                        string anno = Console.ReadLine();

                        libros[numLibros++] = new Libro(titulo, autor, anno);// Esta linea indica que el array libros añade Nuevos lirbos [numlibros++], creando un objeto con el otro lado de la igualdad.
                        Console.WriteLine("Libro añadidos correctamente.");
                        break;

                    case 2: //En este caso, utilizamos un bucle for para recorrer todo el array y mostar los libros que en el se estan guardando.
                        Console.WriteLine("Libros añadidos:");
                        for (int i = 0; i < numLibros; i++)
                        {
                            Console.WriteLine("{0}. \"{1}\", de {2}, publicado en {3}", i + 1, libros[i].Titulo, libros[i].Autor, libros[i].Anno);
                        }if (numLibros < 1)
                        {
                            Console.WriteLine("1. No hay libros en tu lista.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Introduce el número del libro que quieres borras: ");
                        int numLibro = int.Parse(Console.ReadLine());

                        if(numLibro>numLibros || numLibro < 1)
                        {
                            Console.WriteLine("Libro invalido.");
                            break;
                        }
                        for(int i = numLibro -1; i < numLibros -1; i++)
                        {
                            libros[i] = libros[i + 1];//Esta porción de código nos sirve para que cuando se borra un libro, se desplace hacia la izquierda ocupando su lugar y quedando una lista correctamente ordenada.
                        }
                        numLibros--;
                        Console.WriteLine("Libro borrado correctamente");
                        break;

                    case 4: //En este caso, la variable booleana se torna true, cumpliendo la condicion y saliendo del bucle, terminando la ejecuion de  la aplicacion.
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine();

            }
        }
    }
}
