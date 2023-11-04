using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Classe_Abstrata_Interfaces
{
    public abstract  class Conta
    {
        protected decimal saldo;

        public abstract void creditar(decimal valor);

        
        public void Exibir(){

            Console.WriteLine($"O SEU SALDO {saldo}");
        }
    }
}