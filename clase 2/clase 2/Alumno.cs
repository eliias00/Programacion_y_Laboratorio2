using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_2
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;

        public void calcularFinal()
        {
            Random random = new Random();
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                notaFinal = random.Next(0,10);
            }
            else
                notaFinal = -1;

        }

        public void estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;

        }

        public string mostrar()
        {
            StringBuilder cadena = new StringBuilder();

            if (this.notaFinal == -1)
            {
                cadena.AppendFormat("{0} {1}\nLegajo: {2}\nNota 1: {3} Nota 2: {4}\nNota Final: {5}", this.nombre, this.apellido, this.legajo, this.nota1, this.nota2, "Alumno desaprobado");
            }
            else
            {
                cadena.AppendFormat("{0} {1}\nLegajo: {2}\nNota 1: {3} Nota 2: {4}\nNota Final: {5}", this.nombre, this.apellido, this.legajo, this.nota1, this.nota2, this.notaFinal);
            }
            return cadena.ToString();

        }
    }
}
