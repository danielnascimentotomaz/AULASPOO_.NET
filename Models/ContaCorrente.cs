using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class ContaCorrente
    {
     // Construtor 
       public  ContaCorrente(){

         }
         // Construtor
        public ContaCorrente(int numeroConta){

            this.NumeroConta = numeroConta;
            this.saldo = 0;
        }

        // Atributo
        public int NumeroConta { get; set; }

        private decimal saldo;

        public void Sacar(decimal valor){

            if (saldo >= valor){

                saldo = saldo - valor;
                Console.WriteLine("SAQUE REALIZADO COM SUCESSSO");
            }
            else{
                Console.WriteLine("VALOR DESEJADO É MAIOR QUE O SALDO DISPONIVEL");
            }
        }

        public void ExibirSaldo(){

            Console.WriteLine($"SEU SALDO DISPONIVEL É: {saldo} REAIS");
        }

        public void depositar(decimal valor){
            saldo +=  valor;


        }




        
    }
}