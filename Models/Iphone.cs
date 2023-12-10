using System;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public string Modelo { get; set; }
        public string SistemaOperacional { get; set; }

        public Iphone(string numero, string modelo, string sistemaOperacional) : base(numero)
        {
            Modelo = modelo;
            SistemaOperacional = sistemaOperacional;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na plataforma {SistemaOperacional}");
        }
    }
}