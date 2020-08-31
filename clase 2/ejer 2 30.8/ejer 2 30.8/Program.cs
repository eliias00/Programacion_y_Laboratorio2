using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_2_30._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota[] mascotas = new Mascota[4];
            string respuesta = " ";
            string buffer = " ";

            for (int i = 0; i < mascotas.Length; i++)
            {
                mascotas[i] = new Mascota();

                Console.WriteLine("Ingrese tipo de mascota: ");
                mascotas[i].SeTipo(Console.ReadLine());

                Console.WriteLine("Ingrese edad de mascota: ");
                mascotas[i].SetEdad(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Ingrese peso de mascota: ");
                mascotas[i].SetPeso(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Ingrese nombre de mascota: ");
                mascotas[i].SetNombre(Console.ReadLine());
            }
            Console.WriteLine("Ingrese 1 para datos: \nIngrese 2 para info sobre su mascota: ");
            respuesta = Console.ReadLine();
            if (respuesta == "1")
            {
                promedio(mascotas);
                masViejo(mascotas);
                nombreYTipo(mascotas);
            }
            else
            {
                Console.WriteLine("Ingrese el nombre de la mascota a buscar: ");
                buffer = Console.ReadLine();
                for (int i = 0; i < mascotas.Length; i++)
                {
                    if (mascotas[i].GetNombre() == buffer)
                    {
                        Console.WriteLine("Nombre: {0}", mascotas[i].GetNombre());
                        Console.WriteLine("Tipo: {0}", mascotas[i].GeTipo());
                        Console.WriteLine("Edad: {0}", mascotas[i].GetEdad());
                        Console.WriteLine("Peso: {0}", mascotas[i].GetPeso());
                    }
                }
            }
            Console.ReadKey();
        }
        static void promedio(Mascota[] mascotas)
        {
            int promedio = 0;
            int acumulador = 0;
            for (int i = 0; i < mascotas.Length; i++)
            {
                acumulador += mascotas[i].GetPeso();
            }
            promedio = acumulador / 4;
            Console.WriteLine("promedio: {0}", promedio);
        }
        static void masViejo(Mascota[] mascotas)
        {
            bool flag = true;
            int mEdad = 0;
            string mNombre = " ";

            for (int i = 0; i < mascotas.Length; i++)
            {
                if ((flag == true || mEdad < mascotas[i].GetEdad()) && mascotas[i].GeTipo() == "perro")
                {
                    flag = false;
                    mEdad = mascotas[i].GetEdad();
                    mNombre = mascotas[i].GetNombre();
                }
            }
            Console.WriteLine("\nEl perro mas viejo es: {0} y su edad es: {1}", mNombre, mEdad);
        }
        static void nombreYTipo(Mascota[] mascotas)
        {
            for (int i = 0; i < mascotas.Length; i++)
            {
                if (mascotas[i].GetEdad() > 10 && mascotas[i].GetPeso() < 10)
                {
                    Console.WriteLine("\nNombre: {0}", mascotas[i].GetNombre());
                    Console.WriteLine("\nTipo: {0}", mascotas[i].GeTipo());
                }
            }
        }
    }
}
