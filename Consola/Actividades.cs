using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesConsola
{
    public class Actividades
    {
        public void A1()
        {
            Console.WriteLine("Hola mundo!");
        }

        public void A2()
        {
            Console.WriteLine("Ingrese texto: ");
            string Texto = Console.ReadLine();
            Console.WriteLine("Usted ingresó: " + Texto);
        }

        public void A3()
        {
            ConsoleKeyInfo Tecla;
            do
            {
                Console.WriteLine("Presione la tecla X para salir");
                Tecla = Console.ReadKey(true);
            }
            while (Tecla.Key != ConsoleKey.X);
        }

        public void A4()
        {
            string Frase;
            do
            {
                Console.WriteLine("Ingrese una frase: ");
                Frase = Console.ReadLine();
            } while (Frase != "fin");
        }

        public void A5()
        {
            ConsoleKeyInfo Tecla;

            do
            {
                Console.WriteLine("Presione Ctrl + F para salir");
                Tecla = Console.ReadKey(true);
            } while (Tecla.Modifiers != ConsoleModifiers.Control && Tecla.Key != ConsoleKey.F);

        }
    }
}
