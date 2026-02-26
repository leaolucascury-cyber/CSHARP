double a, b, c;

Console.Write("Digite o primeiro lado: ");
a = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo lado: ");
b = double.Parse(Console.ReadLine());

Console.Write("Digite o terceiro lado: ");
c = double.Parse(Console.ReadLine());

if (a == b && b == c)
{
    Console.WriteLine("Triângulo Equilátero");
}
else if (a == b || a == c || b == c)
{
    Console.WriteLine("Triângulo Isósceles");
}
else
{
    Console.WriteLine("Triângulo Escaleno");
}