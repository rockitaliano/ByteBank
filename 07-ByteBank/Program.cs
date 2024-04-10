using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(123, 7070); // Construção do objeto
            Console.WriteLine(ContaCorrente.GetAll());
            //conta.Numero = 123;
            //conta.Agencia = -10;

            ContaCorrente contaGabriela = new ContaCorrente(123, 8080);
            

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);
            Console.WriteLine(ContaCorrente.GetAll());
            Console.ReadKey();

        }
    }
}
