using System;

namespace L5_AP_1135323
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");

            Console.Write("Número ENTERO: ");
            string numStr2 = Console.ReadLine();
            int num;
            if (!Int32.TryParse(numStr2, out num))
            {
                Console.WriteLine("Error: Debe ingresar un número entero");
                return;
            }

            string result;
            if (num > 0)
            {
                result = "positivo";
            }
            else if (num < 0)
            {
                result = "negativo";
            }
            else
            {
                result = "cero";
            }

            Console.WriteLine("RESULTADO: " + result);
            //////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Ejercicio 2 --------------------------------------------");
            Console.Write("Ingrese un número del 1 al 7 para indicar el día de la semana: ");
            string numStr = Console.ReadLine();
            int num2;
            if (!Int32.TryParse(numStr, out num2))
            {
                Console.WriteLine("Error: Debe ingresar un número");
                return;
            }

            string dia;
            switch (num2)
            {
                case 1:
                    dia = "lunes";
                    break;
                case 2:
                    dia = "martes";
                    break;
                case 3:
                    dia = "miércoles";
                    break;
                case 4:
                    dia = "jueves";
                    break;
                case 5:
                    dia = "viernes";
                    break;
                case 6:
                    dia = "sábado";
                    break;
                case 7:
                    dia = "domingo";
                    break;
                default:
                    Console.WriteLine("Error: El número a ingresar debe estar contenido entre 1 y 7");
                    return;
            }

            Console.WriteLine("DIA: " + dia);
        }
    }
    }

