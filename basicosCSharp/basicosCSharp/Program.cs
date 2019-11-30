using System;

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






        }
    }
}
