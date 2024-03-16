// See https://aka.ms/new-console-template for more information
using laboratorio1;

/*Console.WriteLine("Hello, World!");

Person person = new Person();
person.Name = "Vanessa";
person.LastName = "Choque Surco";
person.Age = 21;

string NombresCompletos = person.GetFullName();

Console.WriteLine(NombresCompletos);

Console.Read();*/

//Menu

Grifo grifo = new Grifo();

int opcion;
do
{
    Console.WriteLine("---- MENU DE OPCIONES ----");
    Console.WriteLine("1: Mostrar Informacion de Usuarios");
    Console.WriteLine("2: Agregar Cliente");
    Console.WriteLine("3: Agregar Empleado");
    Console.WriteLine("4: Salir");
    Console.Write("Selecciona una opcion: ");

    opcion = LeerOpcion();

    switch (opcion)
    {
        case 1:
            grifo.MostrarUsuarios();
            break;
        case 2:
            Console.Write("Ingrese el Nombre de cliente: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el Saldo de cliente: ");
            double saldo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese lOS litros cargado de cliente: ");
            double litroscargados = Convert.ToDouble(Console.ReadLine());

            grifo.AddUser(new Cliente(nombre, saldo, litroscargados));
            break;
        case 3:
            Console.Write("Ingrese el Nombre de empleado: ");
            string nombreemp = Console.ReadLine();
            Console.Write("Ingrese el Saldo de empleado: ");
            double saldoemp = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese lOS Sueldo de empleado: ");
            double sueldo = Convert.ToDouble(Console.ReadLine());

            grifo.AddUser(new Empleado(nombreemp, saldoemp, sueldo));
            break;
        case 4:
            Console.WriteLine("Saliendo...");
            return;
    }

} while (true);


static int LeerOpcion()
{
    int opcion;
    while (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Ingresar una opcion valida");
    }
    return opcion;
}