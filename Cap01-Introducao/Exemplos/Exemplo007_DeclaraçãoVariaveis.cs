public static class Exemplo007_DeclaracaoVariaveis
{
    public static void Run()
    {
        string nome;
        int idade;
        Console.WriteLine("Insira o seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Insira a sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Bem vindo {0}. Tem {1} ano(s).", nome, idade);
    }
}