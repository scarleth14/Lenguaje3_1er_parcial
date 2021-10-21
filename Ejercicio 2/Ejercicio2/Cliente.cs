using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Cliente
    {
        public string NombreCliente { get; set; }
        public string Genero { get; set; }
        public string Correo { get; set; }
        public int Edad { get; set; }

        public Cliente() { }

        public Cliente(string nombreCliente, string genero, string correo, int edad)
        {
            NombreCliente = nombreCliente;
            Genero = genero;
            Correo = correo;
            Edad = edad;
        }
    }
}
