using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Pessoa
    {
        //CONSTRUTOR
        public Pessoa(string nome, int Idade){

            this.Nome = nome;
            this.Idade = Idade;
            
        }
        
        // Construtor vazio 
        public Pessoa(){
  
        }
       // ATRIBUTO
        public string Nome { get; set; }
        public int Idade {get;set;}

       // Colocando a palavra virtual que dizer que esse método pode ser sobrescrito assim se a classe filha deseja(polimorfismo)
        public virtual void Apresentar(){


            Console.WriteLine($"OLÁ, MEU NOME É {Nome} E TENHO {Idade} ANOS!");
        }


    }
}