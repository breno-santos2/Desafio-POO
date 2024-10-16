using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Nokia
        Nokia nokia = new("987654321", "Nokia 3310", "Nokia", 16, "Feature OS");
        Smartphone.Ligar();
        Smartphone.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");

        Console.WriteLine(); // Apenas para espaçamento

        // Criando um objeto da classe Iphone
        Iphone iphone = new("123456789", "iPhone 12", "Apple", 64, "iOS 14");
        Smartphone.Ligar();
        Smartphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
