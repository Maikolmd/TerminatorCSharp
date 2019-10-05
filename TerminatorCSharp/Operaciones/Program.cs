using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminatorModel.DTO;

namespace TerminatorCSharp
{
   public partial class Program
    {
        static void IngresarTerminator()

        {
            string tipo = "";
            bool karin = true;
            int numeroSerie = 0;
            int prioridadBase = 0;
            string objetivo = "";
            Int32 añoDeDestino = 32;
            bool continuar = true;

            try
            {
                do
                {
                    Console.WriteLine("Ingrese Numero de serie");
                    karin = int
                    .TryParse(Console.ReadLine().Trim()
                     , out numeroSerie);

                    if (numeroSerie <= 9999999)
                    {
                        if (numeroSerie >= 1000000)
                        {
                            Console.WriteLine("Numero ingresado");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Error Ingrese numero de 7 cifras");
                            karin = false;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingrese numero de 7 cifras");
                        karin = false;
                        Console.Clear();
                    }

                } while (!karin);
            }
            catch (Exception)
            {
                Console.WriteLine("INGRESE UN VALOR NUMERICO");
            }
            do
            {
                Console.Clear();
                Console.WriteLine("a) T-1");
                Console.WriteLine("b) T-800");
                Console.WriteLine("c) T-1000");
                Console.WriteLine("d) T-3000");
                switch (Console.ReadLine().Trim())
                {
                    case "a":
                        tipo = "T-1";
                        break;
                    case "b":
                        tipo = "T-800";
                        break;
                    case "c":
                        tipo = "T-1000";
                        break;
                    case "d":
                        tipo = "T-3000";
                        break;
                    default:
                        Console.WriteLine(" Error Ingrese opcion correcta");
                        continuar = false;
                        break;
                }
                if (tipo == string.Empty)
                {
                    continuar = false;
                }
                else
                {
                    Console.Clear();
                    continuar = true;
                }
            } while (!continuar);

            do
            {
                Console.WriteLine("Ingrese prioridad");
                continuar = int
                  .TryParse(Console.ReadLine().Trim()
                   , out prioridadBase);

                if (prioridadBase == 0)
                {
                    Console.WriteLine("Datos incorrectos ingrese prioridad");
                    continuar = false;
                }
            } while (!continuar);
            do
            {
                Console.WriteLine("Ingrese objetivo");
                Console.WriteLine(objetivo = Console.ReadLine());
                if (objetivo == string.Empty)
                {
                    Console.WriteLine("Datos No Ingresados Datos");
                    continuar = false;
                }
                else
                {
                    if (objetivo.Equals("sarah connor"))
                    {
                        Console.ReadKey();
                        prioridadBase = 999;
                        Console.WriteLine("Su objetivo es sarah connor matela");
                        Console.WriteLine("Su prioridad cambio a estado maximo");
                        continuar = true;
                    }
                    continuar = true;
                }
            } while (!continuar);

            do
            {
                Console.WriteLine("Ingrese año de destino");
            } while (!continuar);


            Terminator t = new Terminator()
            {
                Nserie = numeroSerie,
                Tipo = tipo,
                Prioridad = prioridadBase,
                Objetivo = objetivo,
                Destino = añoDeDestino
            };
            new TerminatorDAL().AgregarTerminator(t);
        }

    }
}
