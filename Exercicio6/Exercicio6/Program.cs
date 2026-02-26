double valor;

Console.Write("Digite um número: ");
valor = double.Parse(Console.ReadLine());

if (valor < 0)
{
    valor = valor * -1;
}
else
{
    valor = valor;
}

Console.WriteLine("Valor absoluto: " + valor);