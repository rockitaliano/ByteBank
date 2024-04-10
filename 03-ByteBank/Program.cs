using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.titular = "Gabriela";
            contaCorrente.agencia = 863;
            contaCorrente.numero = 863452;

            ContaCorrente contaCorrente2 = new ContaCorrente();
            contaCorrente.titular = "Gabriela";
            contaCorrente.agencia = 863;
            contaCorrente.numero = 863452;

            int idade = 27;
            int idadedoze = 27;

            Console.WriteLine("Igualdade de tipo de referência:" + (contaCorrente == contaCorrente2)); // false
            Console.WriteLine("Igualdade de tipo de valor:" + (idade == idadedoze)); // true

            contaCorrente = contaCorrente2;

            Console.WriteLine(contaCorrente.ativo);

            Console.WriteLine("\n============= Novo ===========\n");

            ContaCorrente conta = new ContaCorrente();
            conta.saldo = 200;
            Console.WriteLine(conta.saldo);

            conta.saldo += 100;
            Console.WriteLine(conta.saldo);

            ContaCorrente segundaContaCorrente = new ContaCorrente();
            segundaContaCorrente.saldo = 50;

            Console.WriteLine("primeira conta tem " + conta.saldo);
            Console.WriteLine("segunda conta tem " + segundaContaCorrente.saldo);

            if (conta.saldo >= 100)
            {
                conta.saldo -= 100;
            }

            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
