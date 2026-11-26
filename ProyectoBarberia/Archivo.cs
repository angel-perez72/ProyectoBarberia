
using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace ProyectoBarberia
{
    internal class Archivos
    {
        private static string ruta = Path.Combine(AppContext.BaseDirectory, @"..\..\..\Archivos\");

        public static void CrearCarpeta()
        {
            Directory.CreateDirectory(ruta);
        }

        public static void GuardarClientes(List<Cliente> clientes)
        {
            List<string> lineas = new List<string>();

            foreach (Cliente cliente in clientes)
            {
                lineas.Add(cliente.Id + "|" + cliente.Nombre + "|" + cliente.Telefono);
            }

            File.WriteAllLines(ruta + "Clientes.txt", lineas);
        }

        public static void CargarClientes(List<Cliente> clientes)
        {
            if (File.Exists(ruta + "Clientes.txt"))
            {
                string[] lineas = File.ReadAllLines(ruta + "Clientes.txt");

                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split('|');

                    Cliente cliente = new Cliente();

                    cliente.Id = Convert.ToInt32(datos[0]);
                    cliente.Nombre = datos[1];
                    cliente.Telefono = datos[2];

                    clientes.Add(cliente);
                }
            }
        }

        public static void GuardarBarberos(List<Barbero> barberos)
        {
            List<string> lineas = new List<string>();

            foreach (Barbero barbero in barberos)
            {
                lineas.Add(barbero.Id + "|" + barbero.Nombre);
            }

            File.WriteAllLines(ruta + "Barberos.txt", lineas);
        }

        public static void CargarBarberos(List<Barbero> barberos)
        {
            if (File.Exists(ruta + "Barberos.txt"))
            {
                string[] lineas = File.ReadAllLines(ruta + "Barberos.txt");

                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split('|');

                    Barbero barbero = new Barbero();

                    barbero.Id = Convert.ToInt32(datos[0]);
                    barbero.Nombre = datos[1];

                    barberos.Add(barbero);
                }
            }
        }

        public static void GuardarCitas(List<Cita> citas)
        {
            List<string> lineas = new List<string>();

            foreach (Cita cita in citas)
            {
                lineas.Add(cita.Id + "|" + cita.IdCliente + "|" + cita.IdBarbero + "|" + cita.Fecha + "|" + cita.Hora + "|" + cita.Estado);
            }

            File.WriteAllLines(ruta + "Citas.txt", lineas);
        }

        public static void CargarCitas(List<Cita> citas)
        {
            if (File.Exists(ruta + "Citas.txt"))
            {
                string[] lineas = File.ReadAllLines(ruta + "Citas.txt");

                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split('|');

                    Cita cita = new Cita();

                    cita.Id = Convert.ToInt32(datos[0]);
                    cita.IdCliente = Convert.ToInt32(datos[1]);
                    cita.IdBarbero = Convert.ToInt32(datos[2]);
                    cita.Fecha = datos[3];
                    cita.Hora = datos[4];
                    cita.Estado = datos[5];

                    citas.Add(cita);
                }
            }
        }

        public static void GuardarServicios(List<ServicioRealizado> serviciosRealizados)
        {
            List<string> lineas = new List<string>();

            foreach (ServicioRealizado servicio in serviciosRealizados)
            {
                lineas.Add(servicio.Id + "|" + servicio.IdCita + "|" + servicio.Monto.ToString(CultureInfo.InvariantCulture));
            }

            File.WriteAllLines(ruta + "ServiciosRealizados.txt", lineas);
        }

        public static void CargarServicios(List<ServicioRealizado> serviciosRealizados)
        {
            if (File.Exists(ruta + "ServiciosRealizados.txt"))
            {
                string[] lineas = File.ReadAllLines(ruta + "ServiciosRealizados.txt");

                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split('|');

                    ServicioRealizado servicio = new ServicioRealizado();

                    servicio.Id = Convert.ToInt32(datos[0]);
                    servicio.IdCita = Convert.ToInt32(datos[1]);
                    servicio.Monto = Convert.ToDecimal(datos[2], CultureInfo.InvariantCulture);

                    serviciosRealizados.Add(servicio);
                }
            }
        }
    }
}
