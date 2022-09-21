using System;
using BancoFortuna;

namespace BancoFortuna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boas Vindas ao seu banco, Banco Fortuna!");

            ContaCorrente contas = new ContaCorrente();
            contas.titular = "Andreia Silveira";
            contas.cpf = "123456/123.33";
            contas.conta = "12310/X";
            contas.numero_agencia = 23;
            contas.nome_agencia = "Banco Fortuna";
            contas.saldo = 50.11;

            ContaCorrente contas2 = new ContaCorrente();
            contas2.titular = "Andre Otario";
            //contas2.cpf = "112345/123/22";
            //contas2.conta = "12311/X";
            //contas2.numero_agencia = 24;
            //contas2.nome_agencia = "Banco Fortuna";
            //contas2.saldo = 100.01;
           

            Console.WriteLine("Titular: "+ contas.titular);
            Console.WriteLine("cpf: " + contas.cpf);
            Console.WriteLine("Conta: " + contas.conta);
            Console.WriteLine("Numero Agencia: " + contas.numero_agencia);
            Console.WriteLine("Nome Agencia:  " + contas.nome_agencia);
            Console.WriteLine("Saldo: " + contas.saldo);
            

            Console.ReadKey();
        }
    }
}
