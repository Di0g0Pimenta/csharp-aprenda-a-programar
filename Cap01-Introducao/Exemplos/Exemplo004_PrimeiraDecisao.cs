public static class Exemplo004_PrimeiraDecisao
{
    public static void Run()
    {
        int numero1, numero2;
        Console.WriteLine("Insira um número: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insira o outro número: ");
        numero2 = Convert.ToInt32(Console.ReadLine());
        if (numero1 > numero2)
        {
            Console.WriteLine("O maior numero é: {0}", numero1);
        }
        else 
        {
            Console.WriteLine("O maior numero é: {0}", numero2);
        }
    }
}