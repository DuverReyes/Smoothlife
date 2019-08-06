using System;

namespace Smoothlife
{
    class Program
    {
        static void Main(string[] args)
        {
            Dato Item = new Dato();
            Console.WriteLine("Ingrese numero de platillos");
            int x = int.Parse(Console.ReadLine());
            Item.IngresarPlatillo(x);
            Item.ImprimirPlatillo();

            Console.ReadLine();
        }
    }

    //:)
}
