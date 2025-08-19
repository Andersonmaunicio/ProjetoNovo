using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa //Classe
    {
        public string Nome { get; set; } //Propriedade
        public int Idade { get; set; } //Propriedade

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
        
    }
}