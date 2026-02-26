int valor;

Console.Write("Digite um número: ");
valor = int.Parse(Console.ReadLine());

if (valor >= 0 && valor <= 9)
{
    Console.WriteLine("Valor Válido");
}
else
{
    Console.WriteLine("Valor Inválido");
}