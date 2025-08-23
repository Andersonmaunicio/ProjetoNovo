using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa // Classe
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome) // Construtor
        {
            Nome = nome;
            Sobrenome = sobrenome;

        }

        public void Deconstruct(out string nome, out string sobrenome) // Dersconstruct desmonta
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome;
        private int _idade;

        public string Nome
        {
            get => _nome.ToUpper(); //Código com 1 única linha utilizar o Body Expressions


            set
            {
                if (value == "") // Argumento que está recebendo o nome
                {
                    throw new ArgumentException("O nome não pode ser vazio"); // Exceção: Não permiti que o código continue ser executado
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();


        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que Zero");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto} , Idade: {Idade}");
        }
        
    }
}