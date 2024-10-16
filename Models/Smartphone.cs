namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Memoria { get; set; } // em GB
        public string SistemaOperacional { get; set; }

        public Smartphone(string numero, string modelo, string marca, int memoria, string sistemaOperacional)
        {
            Numero = numero;
            Modelo = modelo;
            Marca = marca;
            Memoria = memoria;
            SistemaOperacional = sistemaOperacional;
        }

        public static void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public static void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}