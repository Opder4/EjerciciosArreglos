int cantidad = 0;
int posicion = 0;
int repeticiones = 0;
double valornuevo = 0;

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

Console.WriteLine($"Ingrese la posición a cambiar su valor");
Console.WriteLine();

while (!int.TryParse(Console.ReadLine(), out posicion) || posicion<0)
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

Console.WriteLine("Ingrese el nuevo valor");
Console.WriteLine();
while (!double.TryParse(Console.ReadLine(), out valornuevo))
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

numeros[posicion] = valornuevo;

Console.WriteLine("El valor ha sido cambiado correctamente");





