using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminatorCSharp
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            while (Menu());
        }
        static bool Menu()
        {
            bool cont = true;
            Console.WriteLine("1.Ingresar Terminator");
            Console.WriteLine("2.Mostrar Terminator");
            Console.WriteLine("3.Buscar Terminator");
            Console.WriteLine("0.Salir");
            Console.ReadKey();
            switch (Console.ReadLine().Trim())
            {
                case "1": IngresarTerminator();
                    break;
                case "2": MostrarTerminator();
                    break;
                case "3": BuscarTerminator();
                    break;
                case "0": cont = false;
                    break;
                default: Console.WriteLine("error escribe bien");
                    break;
            }
            return cont;
        }
    }
}
