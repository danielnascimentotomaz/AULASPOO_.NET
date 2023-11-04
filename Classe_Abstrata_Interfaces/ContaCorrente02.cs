using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Classe_Abstrata_Interfaces
{
    public class ContaCorrente02 : Conta
    {
        public override void creditar(decimal valor)
        {
            saldo = saldo + valor;
        }
    }
}