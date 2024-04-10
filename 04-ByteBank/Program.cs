using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente();

            contaBruno.titular = "Bruno";

            Console.WriteLine("Saldo anterior: R$ " + contaBruno.saldo);

            //contaBruno.Sacar(50);

            bool resultado = contaBruno.Sacar(50);

            Console.WriteLine("Saldo Após o saque: R$ " + contaBruno.saldo);
            Console.WriteLine("Cliente tem saldo em conta: " + resultado);

            contaBruno.Depositar(500);
            Console.WriteLine("Saldo Após o deposito: R$ " + contaBruno.saldo);

            Console.WriteLine("\n====================== Tranferir =======================\n");

            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo Bruno: R$ " + contaBruno.saldo);
            Console.WriteLine("Saldo Gabriela: R$ " + contaGabriela.saldo);

            contaBruno.Transferir(200, contaGabriela);

            Console.WriteLine("Saldo Bruno: R$ " + contaBruno.saldo);
            Console.WriteLine("Saldo Gabriela: R$ " + contaGabriela.saldo);

            Console.ReadKey();
        }
    }
}
