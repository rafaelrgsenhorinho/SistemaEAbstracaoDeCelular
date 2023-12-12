using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_e_Abstraindo_um_Celular_com_POO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o {nomeApp}...");
            Console.WriteLine($"...");
            Console.WriteLine($"Instalação do {nomeApp} concluída!");
        }
    }
}