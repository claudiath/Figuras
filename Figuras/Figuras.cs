using System;
using System.Collections.Generic;
using System.Text;

namespace Figuras
{
    class Figuras
    {
        public decimal area {get; set;} // get y set son de tipo lectura y escritura, sintaxis para declarar un atributo
        decimal lado;
        decimal ancho;
        decimal radio;

        public void areaCuadrado(lado, area)
        {
            Console.WriteLine("Escribe el lado: ");
            lado = Convert.ToDecimal (Console.ReadLine());
            area = lado * lado;
            Console.WriteLine("El resultado del área es: " + area);
        }
    
    }
}