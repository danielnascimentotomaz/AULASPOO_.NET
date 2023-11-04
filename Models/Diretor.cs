using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{

    /// classe selada  classe que não pode ser herdada
    public  sealed class Diretor : Professor
    {
      

        public Diretor(string nome,int Idade,decimal salario) : base(nome,Idade,salario){
           
            
            
        }
      
        public override void Apresentar(){

            Console.WriteLine("DIRETOR");
        }
        
    }
} 