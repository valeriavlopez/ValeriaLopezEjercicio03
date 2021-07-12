using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValeriaLopezEjercicio03
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Title = "Ejercicio 03";
            Double TemperaturaEnCelsius, ResultadoFahrenheit, MayorTemp, PromedioTemp, SumaTemp;
            TemperaturaEnCelsius = 0;
            ResultadoFahrenheit = 0;
            MayorTemp = -70;
            PromedioTemp = 0;
            SumaTemp = 0;            
            Console.WriteLine("Escribir 5 temperaturas");
            for (int Contador = 1; Contador <= 5; Contador++)
            {
                Console.Write("Ingresar una temperatura en Grados Celcius: ");
                TemperaturaEnCelsius = Convert.ToDouble(Console.ReadLine());
                if (TemperaturaEnCelsius>= -70 && TemperaturaEnCelsius <= 60)
                {
                    ResultadoFahrenheit = ConvertiraFarenheit(TemperaturaEnCelsius); //Funcion
                    Console.WriteLine($"La conversión a Grados Fahrenheit es: {ResultadoFahrenheit} ");
                    if (TemperaturaEnCelsius>MayorTemp)
                    {
                        MayorTemp = TemperaturaEnCelsius;
                    }
                    SumaTemp = SumaTemp + TemperaturaEnCelsius;
                }
                else
                {
                    Console.WriteLine("La temperatura ingresada no esta en un rango correcto");
                    Contador = Contador - 1;
                }
            }
            PromedioTemp = SumaTemp / 5;
            Console.WriteLine($"El promedio de las temperaturas ingresadas es: {PromedioTemp}");
            Console.WriteLine($"La mayor temperatura ingresadas es: {MayorTemp}");
            Console.ReadLine();


        }

        private static double ConvertiraFarenheit(double temperaturaEnCelsius)
        {
            return (1.8 * temperaturaEnCelsius) + 32;
        }

    }
}
