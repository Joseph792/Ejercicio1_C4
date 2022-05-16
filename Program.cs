// See https://aka.ms/new-console-template for more information
int rango;

Console.WriteLine("Introduzca el limite de la tabla: ");
rango = Convert.ToInt16(Console.ReadLine());

for(int i=1; i<=rango; i++)
{
    for(int j = 0; j <= 10; j++)
    Console.WriteLine(i + "x" + j + "=" + (i*j));
    Console.WriteLine("");
}
Console.ReadKey();