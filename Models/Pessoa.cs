using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa // Classe
    {
        private string _nome;
        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }

            set
            {
                if (value == "") // Argumento que está recebendo o nome
                {
                    throw new ArgumentException("O nome não pode ser vazio"); // Exceção: Não permiti que o código continue ser executado
                }

                _nome = value;
            }
        } //Propriedade


        public int Idade { get; set; } //Propriedade

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
        
    }
}