
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

            Console.WriteLine("Datos del Cliente: ");
            Console.WriteLine();
            Console.Write("Id: ");
            nuevoCliente.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nombre: ");
            nuevoCliente.Nombre = Console.ReadLine();

            Console.Write("Telefono: ");
            nuevoCliente.Telefono = Console.ReadLine();

            clientes.Add(nuevoCliente);
            Console.WriteLine();
            Console.WriteLine("\tCLIENTE REGISTRADO!");
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