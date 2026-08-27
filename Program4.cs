Console.WriteLine("Por favor, digite um número inteiro:");
string entrada = Console.ReadLine();

if (int.TryParse(entrada, out int numero))
{
    Console.WriteLine($"Você digitou: {numero}");
}
else
{
    Console.WriteLine("Erro: O valor digitado não é um número inteiro válido.");
}
