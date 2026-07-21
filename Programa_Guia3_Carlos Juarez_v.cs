internal class Program
{
    private static void Main(string[] args) 
    {
        string[,] p = new string[10, 3];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                p[i, j] = "";
            }
        }

        int o = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("===MENU PRINCIPAL===");
            Console.WriteLine("1 - Registrar producto");
            Console.WriteLine("2 - Mostrar productos");
            Console.WriteLine("3 - Actualizar producto");
            Console.WriteLine("4 - Eliminar producto");
            Console.WriteLine("5 - Salir");
            Console.Write("Seleccione una opcion: ");

            int.TryParse(Console.ReadLine(), out o);

            switch (o)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("REGISTRAR PRODUCTOS");
                    Registrar(p);
                    Console.WriteLine("Presione para continuar");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("MOSTRAR PRODUCTOS");
                    MostrarE(p);
                    Console.WriteLine("Presione para continuar");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("ACTUALIZAR PRODUCTOS");
                    Actualizar(p);
                    Console.WriteLine("Presione para continuar");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("ELIMINAR PRODUCTOS");
                    Eliminar(p);
                    Console.WriteLine("Presione para continuar");
                    Console.ReadKey();
                    break;
            }

        } while (o != 5);
    }

    static void Registrar(string[,] p2)
    {
        bool registrado = false;

        for (int i = 0; i < 10; i++)
        {
            if (p2[i, 0] == "" && !registrado)
            {
                Console.Write("Codigo: ");
                p2[i, 0] = Console.ReadLine();

                Console.Write("Producto: ");
                p2[i, 1] = Console.ReadLine();

                Console.Write("Cantidad: ");
                p2[i, 2] = Console.ReadLine();

                Console.WriteLine("PRODUCTO REGISTRADO.");
                registrado = true;
            }
        }

        if (!registrado)
        {
            Console.WriteLine("Matriz llena");
        }
    }

    static void MostrarE(string[,] p3)
    {
        Console.WriteLine("CODIGO    PRODUCTO    CANTIDAD");
        for (int i = 0; i < 10; i++)
        {
            if (p3[i, 0] != "")
            {
                Console.WriteLine($"{p3[i, 0]}    {p3[i, 1]}    {p3[i, 2]}");
            }
        }
    }

    static void Actualizar(string[,] p4)
    {
        Console.Write("Codigo a buscar: ");
        string c = Console.ReadLine();

        for (int i = 0; i < 10; i++)
        {
            if (p4[i, 0] == c)
            {
                Console.Write("Nuevo Producto: ");
                p4[i, 1] = Console.ReadLine();

                Console.Write("Nueva Cantidad: ");
                p4[i, 2] = Console.ReadLine();

                Console.WriteLine("Producto actualizado.");
            }
        }
    }

    static void Eliminar(string[,] p5)
    {
        Console.Write("Codigo a eliminar: ");
        string c = Console.ReadLine();

        for (int i = 0; i < 10; i++)
        {
            if (p5[i, 0] == c)
            {
                p5[i, 0] = "";
                p5[i, 1] = "";
                p5[i, 2] = "";
                Console.WriteLine("eliminado");
            }
        }
    }
}