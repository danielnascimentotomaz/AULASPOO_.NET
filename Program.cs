using POO.Models;
using POO.Classe_Abstrata_Interfaces;
using POO.Interfaces;
{
    
}
/*
// Instanciando classe pessoa
Pessoa P1 = new Pessoa("DANIELA SILVA");

// ATRIBUINDO VALORES
P1.Idade = 26;

P1.Apresentar();

/////////////////////////////////////////////////////////
*/
Console.WriteLine("--------------------------------");

// Instanciando classe conta corrente
ContaCorrente C1 = new ContaCorrente(20);

C1.depositar(2000);

C1.Sacar(1200);
C1.ExibirSaldo();


////////////////////////////////////////////////////////////
Console.WriteLine("--------------------------------");


// Instanciando classe  aluno


Aluno A1 = new Aluno();



A1.Nome = "Daniel";

A1.Idade = 25;
A1.Nota = 10;

A1.Apresentar();

Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

Aluno aluno2 = new Aluno("Silas",28,9);
aluno2.Apresentar();


//////////////////////////////////////////////////
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
// INSTANCIANDO A CLASSE PROFESSOR

Professor PR1 = new Professor("daniel",45,10000);

PR1.Apresentar();

///////////////////////////////////////////////////////////
/*
Console.WriteLine("--------------------------------");


///INSTANCIANDO DA CLASSE PROFESSOR
Diretor d1 = new Diretor("naildes");

d1.Apresentar();

Console.WriteLine("--------------------------------");
//INSTANCIAMENTO DA CLASSE COMPUTADOR

Computador c1 = new Computador();

Console.WriteLine(c1.ToString());

Console.WriteLine("--------------------------------");
//INSTANCIANDO DA CLASSE CALCULADORA

Calculadora cal = new Calculadora();

Console.WriteLine(cal.Multiplicar(2,4));


/// ou //
// tou usando uma interface  tou passando uma classe que implementa uma interface

ICalculadora  cal1 = new Calculadora();

Console.WriteLine(cal1.Somar(23,56));

*/


