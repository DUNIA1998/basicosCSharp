﻿using System;

namespace basicosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadLine();

            int añoActual = Convert.ToInt32("2019");
            double numeroPI = 3.141592;
            Console.WriteLine("Valores:{0} -- {1}", añoActual, numeroPI);
            decimal montoFactura = 94593.34m + 0.07m;
            float impuestoVenta = 9239.04f;
            Console.WriteLine("Valores:{0} -- {1}", montoFactura, impuestoVenta);
            Char letraInicial = 'P';
            string nombreCurso = letraInicial + "rogramación 11";
            Console.WriteLine("Este es el curso {0}", nombreCurso);
            bool boolVerdadero = true;
            bool boolFalso = false;
            Console.WriteLine("Variables boleanas:{0} y {1}", boolVerdadero, boolFalso);

            double resultadoSuma = 540 + -18.5;
            float resultadoResta = 3458.35f - 334.34f;
            decimal resultadoMultiplicacion = 23.423m * 3423m;
            decimal resultadoDivision = 239.42m / 0.3m;
            decimal resultadoResiduo = 2321.423m % 23m;
            double resultadoPotencia = Math.Pow(78, 2);
            double resultadoRaiz = Math.Sqrt(144);

            int primerNumero = 48;
            int SegundoNumero = 12;
            primerNumero += SegundoNumero;
            primerNumero -= SegundoNumero;
            primerNumero *= SegundoNumero;
            primerNumero /= SegundoNumero;
            primerNumero %= SegundoNumero;
            primerNumero++;
            primerNumero--;




            Console.ReadLine();







        }
    }
}
