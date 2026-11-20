using ProyectoBarberia;

List<Cliente> clientes = new List<Cliente>();

int opcion = 0;

do
{
    Console.Clear();

    Console.WriteLine("EL MEJOR CORTE BARBERSHOP");
    Console.WriteLine();
    Console.WriteLine("\tMENU DE OPCIONES");
    Console.WriteLine();
    Console.WriteLine("1. Registrar clientes");
    Console.WriteLine("2. Gestionar barberos");
    Console.WriteLine("3. Gestionar servicios");
    Console.WriteLine("4. Gestionar citas");
    Console.WriteLine("5. Registrar atencion");
    Console.WriteLine("6. Consultar inventario");
    Console.WriteLine("7. Ver reportes");
    Console.WriteLine("0. Salir");
    Console.WriteLine();
    Console.Write("Seleccione una opcion: ");

    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Clear();

            Cliente nuevoCliente = new Cliente();

            Console.WriteLine("\tREGISTRANDO CLIENTE ");
            Console.WriteLine();
            Console.WriteLine("Datos del Cliente: ");
            Console.WriteLine();

            //validando el id
            bool idValido = false;

            do
            {
                Console.Write("Id: ");
                string entradaId = Console.ReadLine();
                int numeroId = 0;

                if (int.TryParse(entradaId, out numeroId))
                {
                    if (numeroId > 0)
                    {
                        nuevoCliente.Id = numeroId;
                        idValido = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("\tEL ID DEBE SER MAYOR A CERO!");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("\tEL ID DEBE SER UN NUMERO!");
                    Console.WriteLine();
                }
            }
            while (idValido == false);

            //Que no se repita el id
            bool existeCliente = false;

            foreach (Cliente cliente in clientes)
            {
                if (cliente.Id == nuevoCliente.Id)
                {
                    existeCliente = true;
                }
            }

            if (existeCliente == true)
            {
                Console.WriteLine();
                Console.WriteLine("\tYA EXISTE UN CLIENTE CON ESTE ID!");
            }
            else
            {
                //validando el nombre
                do
                {
                    Console.Write("Nombre: ");
                    nuevoCliente.Nombre = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(nuevoCliente.Nombre))
                    {
                        Console.WriteLine();
                        Console.WriteLine("\tEL NOMBRE NO PUEDE ESTAR VACIO!");
                        Console.WriteLine();
                    }

                }
                while (string.IsNullOrWhiteSpace(nuevoCliente.Nombre));

                Console.Write("Telefono: ");
                nuevoCliente.Telefono = Console.ReadLine();

                clientes.Add(nuevoCliente);
                Console.WriteLine();
                Console.WriteLine("\tCLIENTE REGISTRADO!");
            }
            break;

        case 2:
            Console.WriteLine("Gestion de barberos");
            break;

        case 3:
            Console.WriteLine("Gestion de servicios");
            break;

        case 4:
            Console.WriteLine("Gestion de citas");
            break;

        case 5:
            Console.WriteLine("Registrar atencion");
            break;

        case 6:
            Console.WriteLine("Consultar inventario");
            break;

        case 7:
            Console.WriteLine("Ver reportes");
            break;

        case 0:
            Console.WriteLine("Saliendo del sistema");
            break;

        default:
            Console.WriteLine("Opcion incorrecta");
            break;
    }

    Console.ReadKey();

} while (opcion != 0);