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
    Console.WriteLine("2. Ver clientes registrados");
    Console.WriteLine("3. Buscar cliente por Id");
    Console.WriteLine("4. Actualizar cliente");
    Console.WriteLine("5. Eliminar cliente");
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
            Console.Clear();

            Console.WriteLine("\tCLIENTES REGISTRADOS");
            Console.WriteLine();

            if (clientes.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("\tNO HAY CLIENTES REGISTRADOS!");
                Console.WriteLine();
            }
            else
            {
                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine("Id: " + cliente.Id);
                    Console.WriteLine("Nombre: " + cliente.Nombre);
                    Console.WriteLine("Telefono: " + cliente.Telefono);
                    Console.WriteLine("____________________________");
                    Console.WriteLine();
                }
            }
            break;

        case 3:
            Console.Clear();
            Console.WriteLine("\tBUSCAR CLIENTE");
            Console.WriteLine();

            Console.Write("Ingrese el Id del cliente: ");
            int idBuscar = Convert.ToInt32(Console.ReadLine());

            bool clienteEncontrado = false;

            foreach (Cliente cliente in clientes)
            {
                if (cliente.Id == idBuscar)
                {
                    Console.WriteLine();
                    Console.WriteLine("\tCLIENTE ENCONTRADO!");
                    Console.WriteLine();

                    Console.WriteLine("Id: " + cliente.Id);
                    Console.WriteLine("Nombre: " + cliente.Nombre);
                    Console.WriteLine("Telefono: " + cliente.Telefono);

                    clienteEncontrado = true;
                    break;
                }
            }

            if (clienteEncontrado == false)
            {
                Console.WriteLine();
                Console.WriteLine("\tCLIENTE NO ENCONTRADO!");
            }
            break;

        case 4:
            Console.Clear();
            Console.WriteLine("\tACTUALIZAR CLIENTE");
            Console.WriteLine();

            Console.Write("Ingrese el Id del cliente a actualizar: ");
            int idModificar = Convert.ToInt32(Console.ReadLine());

            bool clienteExiste = false;

            foreach (Cliente cliente in clientes)
            {
                if (cliente.Id == idModificar)
                {
                    clienteExiste = true;

                    Console.WriteLine();
                    Console.WriteLine("Nombre actual: " + cliente.Nombre);
                    Console.WriteLine("Telefono actual: " + cliente.Telefono);
                    Console.WriteLine();

                    string nuevoNombre = "";

                    do
                    {
                        Console.Write("Nuevo nombre: ");
                        nuevoNombre = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(nuevoNombre))
                        {
                            Console.WriteLine("El nombre no puede estar vacio.");
                        }

                    } while (string.IsNullOrWhiteSpace(nuevoNombre));

                    string nuevoTelefono = "";

                    Console.Write("Nuevo telefono: ");
                    nuevoTelefono = Console.ReadLine();


                    cliente.Nombre = nuevoNombre;
                    cliente.Telefono = nuevoTelefono;

                    Console.WriteLine();
                    Console.WriteLine("\tCLIENTE ACTUALIZADO!");

                    break;
                }
            }
            if (clienteExiste == false)
            {
                Console.WriteLine();
                Console.WriteLine("\tCLIENTE NO ENCONTRADO!");
            }
            break;

        case 5:
            Console.Clear();

            Console.WriteLine("\tELIMINAR CLIENTE");
            Console.WriteLine();

            Console.Write("Ingrese el ID del cliente: ");
            int idEliminar = Convert.ToInt32(Console.ReadLine());

            bool clienteEliminado = false;

            foreach (Cliente cliente in clientes)
            {
                if (cliente.Id == idEliminar)
                {
                    Console.WriteLine();
                    Console.WriteLine("Nombre: " + cliente.Nombre);
                    Console.WriteLine("Telefono: " + cliente.Telefono);
                    Console.WriteLine();

                    Console.Write("Eliminar este cliente? (S/N): ");
                    string confirmacion = Console.ReadLine();

                    if (confirmacion == "S" || confirmacion == "s")
                    {
                        clientes.Remove(cliente);

                        Console.WriteLine();
                        Console.WriteLine("\tCLIENTE ELIMINADO!");

                        clienteEliminado = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("ELIMINACION CANCELADA!");

                        clienteEliminado = true;
                    }

                    if (clienteEliminado == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine("\tCLIENTE NO ENCONTRADO!");
                    }

                    break;
                }
            }

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