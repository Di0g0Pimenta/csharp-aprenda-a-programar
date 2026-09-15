public static class Exemplo002_LeituraTelcado
{
    public static void Run()
    {
        Console.WriteLine("Como se chama? ");
        //Utilização da palavra nomeProprio para ler o nome do utizador
        string nomeProprio = Console.ReadLine();
        Console.WriteLine("Bem-vindo(a) {0}" , nomeProprio);
    }
}