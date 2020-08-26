using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();
            alumno1.nombre = "Leo";
            alumno2.nombre = "Pepito";
            alumno3.nombre = "Juan";
            alumno1.apellido = "Perez";
            alumno2.apellido = "Almendra";
            alumno3.apellido = "Lopez";
            alumno1.legajo = 11;
            alumno2.legajo = 22;
            alumno3.legajo = 33;

            alumno1.estudiar(9, 9);
            alumno2.estudiar(4, 7);
            alumno3.estudiar(6, 3);
            alumno1.calcularFinal();
            alumno2.calcularFinal();
            alumno3.calcularFinal();
            Console.WriteLine(alumno1.mostrar());
            Console.WriteLine(alumno2.mostrar());
            Console.WriteLine(alumno3.mostrar());

            Console.ReadKey();
        }
    }
}
