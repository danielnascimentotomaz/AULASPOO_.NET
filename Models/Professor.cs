using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Professor: Pessoa

    {

       public decimal Salario  { get; set; }

        // Construtor
        public Professor(string nome, int Idade,decimal salario) : base(nome,Idade){
            this.Salario = salario;
            
        }
        
        // Construtor vazio
        public Professor(){

        }
        
     


        // sobrecresvendo  o método apresentar(polimorfismo)
        public  override void Apresentar(){
            Console.WriteLine($"OLÁ, MEU NOME É {Nome}, TENHO {Idade} ANOS, SOU UM PROFESSOR E GANHO {Salario}");


        }
        
    }
}