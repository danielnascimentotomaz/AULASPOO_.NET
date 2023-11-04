using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);

        int Multiplicar(int num1, int num2);
        // Em interfaces os metodos pode ter corpo também  Quando crio um corpo no método se torna opcional implementar
        int Dividir(int num1, int num2){

            return num1 / num2;
        }
        


        
    }
}