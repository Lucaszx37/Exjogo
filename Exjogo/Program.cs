
Console.WriteLine("Hello, World!");

Random random = new Random();
int secreto = random.Next(1, 11);
int tentativa = 0;

Console.WriteLine("\n=== JOGO DO NUMERO SECRETO ===");
Console.WriteLine("Tente adivinhar um numero de 1 a 10!");

while (tentativa != secreto)
{
    Console.Write("Digite seu palpite: ");
    tentativa = Convert.ToInt32(Console.ReadLine());

    if (tentativa < secreto)
    {
        Console.WriteLine("Muito baixo! Tente novamente.");
    }
    else if (tentativa > secreto)
    {
        Console.WriteLine("Muito alto! Tente novamente.");
    }
    else
    {
        Console.WriteLine("Parabens! Voce venceu!");
    }
}

Console.WriteLine("Fim de jogo!");
Console.ReadKey();
