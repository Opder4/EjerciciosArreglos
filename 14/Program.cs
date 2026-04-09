int cantidad = 0;
double orden = 0;
double valor = 0;

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

Console.WriteLine("Los número ingresados en orden de menor a mayor es:");
Console.WriteLine();
for (int i = 0; i < numeros.Length - 1; i++)
{
    
    for (int j = 0; j < numeros.Length - 1; j++)
    {
     
        if (numeros[j] > numeros[j + 1])
        {
            valor = numeros[j];
            numeros[j] = numeros[j + 1];
            numeros[j + 1] = valor;
        }
    }
}

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write(numeros[i] + " ");
    Console.WriteLine();
}