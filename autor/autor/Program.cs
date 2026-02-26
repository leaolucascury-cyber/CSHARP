using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
public class Program
{
    public static void Main(string[] args)
    {
        Autor autor1 = new Autor("Stephen", "King");
        Autor autor2 = new Autor("J. R. R.", "Tolkien");

        autor1.ExibirInfo();

        autor1.AlterarApelido("Rei do Terror");
        autor1.ExibirInfo();

        Cliente cliente1 = new Cliente("João Silva", "Rua das Flores, 123", "NC001");

        Categoria categoria1 = new Categoria("Fantasia", "Livros de Fantasia");

        Relatorio relatorio1 = new Relatorio(
            "O senhor dos Anéis",
            "Uma aventura épica",
            "Texto... ",
            "image.jpg",
            "Link.com",
            categoria1 );

        Autoria autoria1 = new Autoria(autor2, relatorio1, 1, false);

        Console.WriteLine($"{autoria1.Relatorio.Titulo} por {autoria1.Autor.Nome}" );

        Acesso acesso1 = new Acesso(1, DateTime.Now);
        relatorio1.RegistrarAcesso(acesso1);

        Contrato contrato1 = new Contrato(
            DateTime.Now,
            DateTime.Now.AddMonths(12),
            1000.00,
            cliente1
            );

        Console.WriteLine($"Valor total do contrato: {contrato1.CalcularValorTotal():c}");
    }
}
public class Autor
{ public string Nome { get; set; }
  public string Apelido { get; set; }

    public Autor(string nome, string apelido)
    {
        Nome = nome;
        Apelido = apelido;
    }

    public void ExibirInfo()
    {
        Console.WriteLine($"Nome: {Nome}, Apelido: {Apelido}");
    }

    public void AlterarApelido(string novoApelido)
    {
        Apelido = novoApelido;
    }
}

public class Relatorio
{
    public string Titulo { get; set; }
    public string Resumo { get; set; }
    public string Texto { get; set; }
    public string Imagem { get; set; }
    public string Link { get; set; }
    public Categoria Categoria { get; set; }

    public List<Acesso> Acessos { get; set; } = new List<Acesso>();
    public Relatorio(string titulo, string resumo, string texto, string imagem, string link, Categoria categoria)
    {
        Titulo = titulo;
        Resumo = resumo;
        Texto = texto;
        Imagem = imagem;
        Link = link;
        Categoria = categoria;
    }
    public void RegistrarAcesso(Acesso acesso)
    {
        Acessos.Add(acesso);
    }
}

public class Autoria
{
    public Autor Autor { get; set; }
    public Relatorio Relatorio { get; set; }
    public int Posicao { get; set; }
    public bool Anonimo { get; set; }
    public Autoria(Autor autor, Relatorio relatorio, int posicao, bool anonimo)
    {
        Autor = autor;
        Relatorio = relatorio;
        Posicao = posicao;
        Anonimo = anonimo;
    }
}
public class Cliente
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string NC { get; set; }
    public Cliente(string nome, string endereco, string nc)
    {
        Nome = nome;
        Endereco = endereco;
        NC = nc;
    }
}

public class Contrato
{
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public double ValorMensal { get; set; }
    public Cliente Cliente { get; set; }
    public Contrato(DateTime dataInicio, DateTime dataFim, double valorMensal, Cliente cliente)
    {
        DataInicio = dataInicio;
        DataFim = dataFim;
        ValorMensal = valorMensal;
        Cliente = cliente;
    }

    public double CalcularValorTotal()
    {
       TimeSpan diferenca = DataFim - DataInicio;
        double meses = diferenca.TotalDays / 30;
        return ValorMensal * meses;
    }
}

public class Acesso
{
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public Acesso(int id, DateTime data)
    {
        Id = id;
        Data = data;
    }
}

public class Editor
{ 
    public string Nome { get; set; }
    public string Especialidade { get; set; }
    public Editor(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
    }
    public void ExibirInfo()
    {
        Console.WriteLine($"Nome: {Nome}, Especialidade: {Especialidade}");
    }
}

public class Categoria
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public Categoria(string nome, string descricao)
    {
        Nome = nome;
        Descricao = descricao;
    }
}