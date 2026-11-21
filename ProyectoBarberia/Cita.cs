using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBarberia
{
    internal class Cita
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdBarbero { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Estado { get; set; }
    }
}
