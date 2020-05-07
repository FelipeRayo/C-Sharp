using System;

namespace EjerciciosOscar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Greeting("Hello World"));
            Console.WriteLine(UnoporMi("Felipe"));
            Console.ReadKey();
        }

        static string Greeting(string greeting)
        {
            string saludo = greeting;

            return saludo;
        }


        static string UnoporMi(string nombre)
        {
            string respuesta;
            if (nombre == String.Empty)
            {
                 respuesta = "Uno por ti, uno por mi";
            }
            else
            {
                 respuesta = "Uno por " + nombre + ", uno por mi";
            }

            return respuesta;

        }
    }
}
