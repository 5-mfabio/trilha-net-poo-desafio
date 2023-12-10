using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Adicione propriedades específicas para o Nokia, se necessário

        public Nokia() : base("defaultNumero") // Pode adicionar um número padrão aqui
        {
            // Inicialize propriedades específicas do Nokia, se necessário
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            // Lógica específica para instalar aplicativo em um Nokia
            Console.WriteLine($"Instalando {nomeApp} em um Nokia com sistema operacional próprio");
        }
    }
}