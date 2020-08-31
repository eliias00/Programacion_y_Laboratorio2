using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_2_30._8
{
    class Mascota
    {
        public string tipo;
        public int edad;
        public int peso;
        public string nombre;
        public void SetNombre(string auxNombre)
        {
            this.nombre = auxNombre;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public void SeTipo(string auxTipo)
        {
            this.tipo = auxTipo;
            while (this.tipo != "perro" && this.tipo != "gato")
            {
                Console.Write("Reingrese tipo: ");
                this.tipo = Console.ReadLine();
            }
        }
        public string GeTipo()
        {
            return this.tipo;
        }

        public void SetEdad(int auxEdad)
        {
            this.edad = auxEdad;
            while (this.edad < 1 || this.edad > 25)
            {
                Console.Write("Reingrese edad: ");
                this.edad = Convert.ToInt32(Console.ReadLine());
            }
        }
        public int GetEdad()
        {
            return this.edad;
        }
        public void SetPeso(int auxPeso)
        {
            this.peso = auxPeso;
            while (this.peso < 1 || this.peso > 100)
            {
                Console.Write("Reingrese peso: ");
                this.peso = Convert.ToInt32(Console.ReadLine());
            }
        }
        public int GetPeso()
        {
            return this.peso;
        } 
    }
}
