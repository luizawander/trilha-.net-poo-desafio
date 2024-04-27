using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Nokia nokia = new Nokia("123456789", "Nokia 3310", "IMEI123", 512);

            
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            
            Iphone iphone = new Iphone("987654321", "iPhone 12", "IMEI456", 256);

            
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.ReadLine();
        }
    }
}