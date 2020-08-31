using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_30._8
{
    class Cliente
    {
         string nombre;
         string apellido;
         int dni;
         string usuario;
         string Clave;
         long numeroDeCuenta;
         float saldo;
        public void SetNombre(string auxNombre)
        {
            this.nombre = auxNombre;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public void SetApellido(string auxApellido)
        {
            this.apellido = auxApellido;
        }
        public string GetApellido()
        {
            return this.apellido;
        }
        public void SetDni(int auxDni)
        {
            this.dni = auxDni;
        }
        public int GetDni()
        {
            return this.dni;
        }
        public void SetUsuario(string auxUsuario)
        {
            this.usuario = auxUsuario;
        }
        public string GetUsuario()
        {
            return this.usuario;
        }
        public void SetClave(string auxClave)
        {
            this.Clave = auxClave;
        }
        public string GetClave()
        {
            return this.Clave;
        }
        public void SetNumeroDeCuenta(long auxNumeroDeCuenta)
        {
            this.numeroDeCuenta = auxNumeroDeCuenta;
        }
        public long GetNumeroDeCuenta()
        {
            return this.numeroDeCuenta;
        }
        public void SetSaldo(float auxSaldo)
        {
            this.saldo = auxSaldo;
        }
        public float GetSaldo()
        {
            return this.saldo;
        }
        public string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();

               cadena.AppendFormat("\nNombre: {0}\nApellido: {1}\nDni: {2}\nUsuario: {3}\nClave: {4}\nCuenta: {5}\nSaldo: {6}",
                   this.nombre, this.apellido, this.dni, this.usuario, this.Clave, this.numeroDeCuenta, this.saldo);

            return cadena.ToString();
        }

        public void AgregarSaldo(int incrementar)
        {
            incrementar = incrementar + Convert.ToInt32( this.saldo);
            SetSaldo(incrementar);
        }

        public bool RetirarDinero(int retirarSaldo)
        {
            bool bandera = false;
            if (retirarSaldo < this.saldo)
            {
                float nuevoSaldo;
                 bandera = true;
                nuevoSaldo = Convert.ToInt32(this.saldo) - retirarSaldo;
                SetSaldo(nuevoSaldo);
            }
            else
               bandera = false;
            return bandera;
        }

    }

}
