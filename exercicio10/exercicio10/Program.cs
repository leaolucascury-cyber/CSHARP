int codigo;

Console.Write("Digite um código (1, 2 ou 3): ");
codigo = int.Parse(Console.ReadLine());

switch (codigo)
{
    case 1:
        Console.WriteLine("Comando Iniciar");
        break;

    case 2:
        Console.WriteLine("Comando Pausar");
        break;

    case 3:
        Console.WriteLine("Comando Encerrar");
        break;

    default:
        Console.WriteLine("Código inválido");
        break;
}