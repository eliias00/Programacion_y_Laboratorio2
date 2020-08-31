using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_30._8
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente1 = new Cliente();

            string usuarioLog = null;
            string claveLog = null;
            string opcion = " ";
            bool resp = false;

            cliente1.SetNombre("Jose");
            cliente1.SetApellido("Perez");
            cliente1.SetDni(33456987);
            cliente1.SetUsuario("Jose2020");
            cliente1.SetClave("AdarleATOMOS123");
            cliente1.SetNumeroDeCuenta(40222576101);
            cliente1.SetSaldo(2000);

            Console.WriteLine("Ingrese Usuario: ");
            do
            {
                usuarioLog = Console.ReadLine();

            } while(string.IsNullOrEmpty(usuarioLog));

            Console.WriteLine("Ingrese Clave: ");
            do
            {
                claveLog = Console.ReadLine();

            } while(string.IsNullOrEmpty(claveLog));

            
            if (usuarioLog == "Jose2020" && claveLog == "AdarleATOMOS123")
            {
                resp = true;
                while (resp)
                {
                Console.WriteLine("\nA) Mostrar Datos");
                Console.WriteLine("\nB) Agrega Dinero");
                Console.WriteLine("\nC) Retirar Dinero");
                opcion = Console.ReadLine();

                if (opcion == "A")
                    Console.WriteLine(cliente1.Mostrar());

                else if (opcion == "B")
                    cliente1.AgregarSaldo(200);
                else
                    cliente1.RetirarDinero(1000);
                   
                }
            }
            Console.ReadKey();
        }
    }
}
