﻿using System;

namespace StaticExercise
{
    class Program
    {
        private static object celcis;

        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68); // 20
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20); //68

            Console.WriteLine("After conversion:");
            Console.WriteLine($"celcis {celcis}");
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
