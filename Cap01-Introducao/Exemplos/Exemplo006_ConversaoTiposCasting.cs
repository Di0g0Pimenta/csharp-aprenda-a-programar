public static class Exemplo006_ConversaoTiposCasting
{
    public static void Run()
    {
        short a = 5;
        int b;
        float c = 8.5f;

        b = a;

        //Na cnversão acima não ha perda de informação
        Console.WriteLine("Inteiro: " + b);
        Console.WriteLine("Real: " + c);
        b = (int)c;

        //Na cnversão acima perde-se a informação do valor decimal
        Console.WriteLine("Inteiro: " + b);
    }
}