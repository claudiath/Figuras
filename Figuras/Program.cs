using System;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = 1;
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("¿Desea utilizar la aplicación para el cálculo del área de alguna figura? <S/N>");
                    string valor = Console.ReadLine();

                    //if (valor == "S" || valor == "s") // || es igual a "or"
                    if (valor.ToUpper()=="S")
                    {
                        Console.Write("Elija la figura a la que le desea calcular el área: \n" +
                         "1. Área de un cuadrado \n" + "2. Área de un rectangulo \n" + "3. Área de un circulo \n");
                        string opcion = Console.ReadLine();

                        Figuras figuras = new Figuras(); // instanciando a la clase Figuras
                        switch (opcion)
                        {
                            case "1": figuras.areaCuadrado(); break;
                            case "2": figuras.areaRectangulo(); break;
                            case "3": figuras.areaCirculo(); break;
                            default:
                                Console.Write("La opción elegida no es válida");
                                break;
                        }
                        n++;
                    }
                    else if (valor == "N" || valor == "n")
                    {
                        return; // retorna a la función principal y se termina la ejecución en curso (se cierra la aplicación)
                    }
 
                }
 
                Console.ReadKey();

                //figuras.areaCuadrado(); // accedemos al método creado
                //figuras.areaRectangulo();
                //figuras.areaCirculo();
            }
            catch (Exception ex)
            {
                Console.WriteLine("La aplicación ha fallado. Contacte con su técnico" + ex.Message);
                // throw;
            }
        }
    }
}
