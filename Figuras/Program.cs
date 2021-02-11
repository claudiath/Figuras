using System;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Figuras figuras = new Figuras(); // instanciando a la clase Figuras
            figuras.areaCuadrado(); // accedemos al método creado
            Console.ReadKey();
        }
    }
}
