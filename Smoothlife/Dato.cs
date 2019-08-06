using System;
using System.Collections.Generic;
using System.Text;

namespace Smoothlife
{
    class Dato
    {
        #region Atributos

        #endregion

        public List<Dato> platillos = new List<Dato>();

        #region  Propiedades

        #endregion

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }


        #region Constructores

        #endregion

        public Dato(string nombre, string descripcion, int precio)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }
        public Dato()
        {

        }

        #region Metodos    

        #endregion

        public  void IngresarPlatillo(int x)
        {

          for (int i = 0; i < x; i++)
            {

                Dato p = new Dato();
            Console.WriteLine("Ingrese el Nombre del Platillo");
            p.Nombre = Console.ReadLine();

            Console.WriteLine("Digite Descripcion");
            p.Descripcion = Console.ReadLine();

            Console.WriteLine("Inserte el Precio");
            p.Precio =int.Parse(Console.ReadLine());
                platillos.Add(p);
           }
        }


        public void ImprimirPlatillo()
        {
            foreach (var p in platillos)
            {
                Console.WriteLine();
                Console.WriteLine($"El Nombre del platillo es:{p.Nombre}");
                Console.WriteLine($"Descripcion:{p.Descripcion}");
                Console.WriteLine($"El valor es:{p.Precio}");
            }
        }



    }

}
