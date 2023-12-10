using System;
using DesafioPOO.Models; // Certifique-se de importar o namespace correto

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste com a classe Nokia
            Nokia nokia = new Nokia();
            nokia.Numero = "123456789";
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("NokiaApp");

            // Teste com a classe Iphone
            Iphone iphone = new Iphone("987654321", "iPhone X", "iOS");
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("iPhoneApp");

            Console.ReadLine();
        }
    }
}