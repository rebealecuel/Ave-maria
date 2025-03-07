using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ave_maria
{
    internal class Program
    {
        public enum Meni
        {
            Agregar = 1, Mostrar, Contar, Eliminar, Actualizar, Salir
        }
        static void Main(string[] args)
        {
            //Rebeca Alejandra Cuellar Angel
            acciones accion = new acciones();
            while (true)
            {
                switch (Menu())
                {
                    case Meni.Agregar:
                        accion.Agregarauto();
                        break; 
                    case Meni.Mostrar:
                        accion.Mostrarauto();
                        break;
                    case Meni.Contar:
                        Console.WriteLine(accion.ContarAutos()); 
                        break;
                    case Meni.Eliminar:
                        Console.WriteLine("Dame una marca a eliminar");
                        string marca = Console.ReadLine();
                        accion.EliminarAuto(marca);
                        break;
                    case Meni.Actualizar:
                        Console.WriteLine("Dame la marca a actualizar");
                        string actua = Console.ReadLine();
                        accion.Actualizar(actua);
                        break;
                    case Meni.Salir:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }

        static Meni Menu()
        {
            Console.WriteLine("1) Agregar");
            Console.WriteLine("2) Mostrar");
            Console.WriteLine("3) Contar");
            Console.WriteLine("4) Eliminar");
            Console.WriteLine("5) Actualizar");
            Console.WriteLine("6) Salir");
            Meni opc = (Meni)Convert.ToInt32(Console.ReadLine());

            return opc;
        }
    }
}
