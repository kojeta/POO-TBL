using System;
using System.Globalization;

public abstract class Funcionario
{
    public string Nome { get; set; }

    protected Funcionario(string nome)
    {
        Nome = nome;
   
    public abstract decimal CalcularSalario();
    }
}

public class Gerente : Funcionario
{
    public decimal Salariobase { get; set; }
    public decimal Bonus { get; set; }

    public Gerente(string nome, decimal Salariobase, decimal Bonus) : base(nome)
    {
        Salariobase = salariobase;
        Bonus = bonus;
    }

    {
        return Salariobase + Bonus;
    }
}

public class Programador : Funcionario
{
    public decimal Salariobase { get; set; }
    public int Horasextras { get; set; }
    public decimal Valorhoraextra { get; set; }

    public Programador(string nome, decimal salariobase, int horasextras, decimal valorhoraextra) : base(nome)
    {
        Salariobase = salariobase;
        Horasextras = horasextras;
        Valorhoraextra = valorhoraextra;
    }

    {
        return Salariobase + (Horasextras * Valorhoraextra);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Funcionario gerente = new Gerente("Carlos Silva", 8000.00m, 2500.00m);
        Funcionario programador = new Programador("Ana Souza", 5000.00m, 12, 60.00m);

        Console.WriteLine($"Gerente: {gerente.Nome}");
        decimal salarioGerente = gerente.CalcularSalario();
        Console.WriteLine($"Salário Total: {salarioGerente.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"))}\n");

        Console.WriteLine($"Programador: {programador.Nome}");
        decimal salarioProgramador = programador.CalcularSalario();
        Console.WriteLine($"Salário Total: {salarioProgramador.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"))}");
    }
} 