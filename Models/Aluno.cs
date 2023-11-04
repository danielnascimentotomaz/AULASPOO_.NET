using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    // A CLASSE ALUNO VAI HERDA TODOS ATRIBUTOS E METODOS DA CLASSE PESSOA
    public class Aluno : Pessoa
    {


        public Aluno(){
            
        }

        
        public Aluno(string nome,int Idade) :
        base(nome,Idade){// chamar o construtor da classe mã
            
        }
        public double Nota{ get; set; }

        public Aluno(string nome,int idade,double nota):base(nome,idade){
            this.Nota= nota;
        }
        
        // sobrecresvendo  o método apresentar(polimorfismo)
        public override void Apresentar(){
            Console.WriteLine($"OLÁ, MEU NOME É {Nome}, TENHO {Idade} ANOS, E SOU UM ALUNO NOTA {Nota}");


        }
        
    }
}