using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testando a classe Iphone
            Iphone iphone = new Iphone("123456789", "iPhone 12", "1234567890", "128GB");
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("WhatsApp");
            iphone.MostrarApps();
            iphone.DesinstalarAplicativo("WhatsApp");
            iphone.MostrarApps();
            iphone.DesinstalarAplicativo("WhatsApp");

            // Testando a classe Nokia
            Nokia nokia = new Nokia("987654321", "Nokia 3310", "9876543210", "16MB");
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Snake");
            iphone.MostrarApps();
            iphone.DesinstalarAplicativo("Snake");
            iphone.MostrarApps();
            iphone.DesinstalarAplicativo("Snake");

        }
    }
}
