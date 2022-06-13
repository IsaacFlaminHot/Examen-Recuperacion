using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen_Recuperacion
{
    class Compras
    {
        public string producto;
        public int cantidad;
        public float precio;

        public Compras(string producto, int cantidad, float precio)
        {
            this.producto = producto;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public void DesplegarDatos()
        {
            Console.WriteLine("El nombre de su producto es: {0}",producto);
            Console.WriteLine("La cantidad de su producto fue de {0} piezas",cantidad);
            Console.WriteLine("El precio de su producto es de {0}$",precio);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("Compras.txt", true);

            string producto;
            int cantidad;
            float precio;

            try
            {
                Console.WriteLine("Bienvenido a su programa de compras.");

                Console.Write("Ingrese el Nombre de su producto: ");
                producto = Console.ReadLine();
                Console.Clear();

                Console.Write("Ingrese cual es la cantidad de su producto: ");
                cantidad = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.Write("Ingrese el precio de su producto: ");
                precio = float.Parse(Console.ReadLine());
                Console.Clear();

                Compras c1 = new Compras(producto, cantidad, precio);

                c1.DesplegarDatos();

                sw.WriteLine("\nEl nombre de su producto es: {0}", c1.producto);
                sw.WriteLine("\nLa cantidad de su producto fue de {0} piezas", c1.cantidad);
                sw.WriteLine("\nEl precio de su producto es de {0}$\n\n\n", c1.precio);

                sw.Close();

                Console.WriteLine("\n\nEscribiendo archivo... ");
                Console.WriteLine("Presione <enter> Para finalizar.");
                Console.ReadKey();



                Console.Clear();
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException x)
            {
                Console.WriteLine(x.Message);
            }
        }
    }
}
