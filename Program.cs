using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Nokia
        Nokia nokia = new Nokia("987654321", "Nokia 3310", "Nokia", 16, "Feature OS");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");

        Console.WriteLine(); // Apenas para espaçamento

        // Criando um objeto da classe Iphone
        Iphone iphone = new Iphone("123456789", "iPhone 12", "Apple", 64, "iOS 14");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
//