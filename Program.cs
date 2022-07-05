using System;

namespace cambiotemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            float celsius;
            float fahrenheit;
            Console.WriteLine("elija Celsius ¨C¨ o Fahrenheit ¨F¨");
            var indicador = Console.ReadLine();
            if (indicador.ToUpper() == "F" || indicador.ToUpper() == "C") 
            {
                if (indicador.ToUpper() == "F")
                {
                    Console.Write("ingrese la temperatura en fahrenheit ");
                    fahrenheit = float.Parse(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine($"su temperatura es igual a {celsius} ");
                 }
                else
                {
                    Console.Write("ingrese la temperatura en celsius ");
                    celsius = float.Parse(Console.ReadLine());
                    fahrenheit = (1 * 8f * celsius + 32);
                    Console.WriteLine($"su temperatura es igual a {fahrenheit}");
                }
        }  
        else
            {
                Console.WriteLine("algun dato ingresado es erroneo");
            }
        }
    }
}
