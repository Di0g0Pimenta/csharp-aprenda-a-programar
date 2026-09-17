public static class Exemplo003_Soma
{
    public static void Run()
    {
        Console.WriteLine("Insira um número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insira o segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        int soma = numero1 + numero2;
        Console.WriteLine("A soma do número {0} com o número {1} é: {2}", numero1, numero2, soma);
    }
}