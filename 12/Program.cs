int cantidad = 0;

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

Console.WriteLine("Los valores positivos son: ");
Console.WriteLine();
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] > 0)
    {
        Console.WriteLine($"{numeros[i]}");
        Console.WriteLine();
    }
    else if (numeros[i] == 0)
    {
        Console.WriteLine("El número 0 no es ni positivo ni negativo");
        Console.WriteLine();
    }
}






