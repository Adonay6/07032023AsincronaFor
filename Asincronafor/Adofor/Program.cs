Console.Write("Ingrese el valor de N que seria la altura del triangulo (entero positivo) : ");
int n = int.Parse(Console.ReadLine());
for(int y = 1; y <= n; y++)
{
    for (int x = 1; x<= y; x++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.ReadKey();