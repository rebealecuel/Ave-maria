using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ave_maria
{
    internal class acciones
    {
        public List<Automovil> Listaautomovil = new List<Automovil>();

        Automovil a = new Automovil();
        

        public void Agregarauto()
        {
            Console.WriteLine("Marca");
            a.Marca = Console.ReadLine();
            Console.WriteLine("Modelo");
            a.Modelo = Console.ReadLine();
            Console.WriteLine("Año");
            a.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numero de puertas");
            a.Numpuertas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Color");
            a.Color = Console.ReadLine();

            Listaautomovil.Add(new Automovil(a.Marca, a.Modelo, a.Año, a.Numpuertas, a.Color));
        }

        public void Mostrarauto()
        {
            foreach (var a in Listaautomovil)
            {
                Console.WriteLine($"Marca: {a.Marca}");
                Console.WriteLine($"Modelo: {a.Modelo}");
                Console.WriteLine($"Año: {a.Año}");
                Console.WriteLine($"Numero de puertas: {a.Numpuertas}");
                Console.WriteLine($"Color: {a.Color}");
            }
        }

        public int ContarAutos()
        {
            return Listaautomovil.Count;
        }

        public void EliminarAuto(string nombremarca)
        {
            var automovil = Listaautomovil.Find(x =>x.Marca == nombremarca);
            if (automovil != null)
                Listaautomovil.Remove(automovil);
            else
                Console.WriteLine("No se encontro tu automovil");
        }

        public void Actualizar(string nombremarca)
        {
            var automovil = Listaautomovil.Find(x => x.Marca == nombremarca);
            if (automovil != null)
            {
                automovil.Marca = Console.ReadLine();
                automovil.Modelo = Console.ReadLine();
                automovil.Año = Convert.ToInt32(Console.ReadLine());
                automovil.Numpuertas = Convert.ToInt32(Console.ReadLine());
                automovil.Color = Console.ReadLine();
                 //La guadalupe
                Console.WriteLine("Automóvil actualizado con éxito.");
            }
            else
            {
                Console.WriteLine("No se encontró tu automóvil.");
            }

        }

    }
}
