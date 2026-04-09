int cantidad = 0;
double numerobuscar = 0;

Console.WriteLine("Ingrese cuantos números quiere ingresar: ");
Console.WriteLine();
while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
{
    Console.WriteLine();
    Console.WriteLine("Dato no válido");
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Presione ENTER para continuar");
Console.WriteLine("");
Console.ReadLine();
Console.Clear();

double[] numeros = new double[cantidad];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Ingrese el {i + 1}° números");
    Console.WriteLine();
    while (!double.TryParse(Console.ReadLine(), out numeros[i]))
    {
        Console.WriteLine("");
        Console.WriteLine("Dato no válido");
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Presione ENTER para continuar");
    Console.WriteLine("");
    Console.ReadLine();
    Console.Clear();
}

Console.WriteLine("Ingrese el número que quiere buscar: ");
Console.WriteLine();
while (!double.TryParse(Console.ReadLine(), out numerobuscar))
{
    Console.WriteLine("");
    Console.WriteLine("Dato no válido");
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Presione ENTER para continuar");
Console.WriteLine("");
Console.ReadLine();
Console.Clear();

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i]==numerobuscar)
    {
        Console.WriteLine($"El número {numerobuscar} se encuentra en la posición {i}");
        Console.WriteLine();
    }
    else
    {

    }
}

    



