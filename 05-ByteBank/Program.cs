using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();
            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Dev C#";
            //gabriela.cpf = "123.456.789-01";


            //ContaCorrente conta = new ContaCorrente();
            //conta.titular = new Cliente();
            ////conta.titular = gabriela;
            //conta.saldo = 500;
            //conta.agencia = 563;
            //conta.numero = 5634527;

            // Console.WriteLine(gabriela.nome);
                        
           
            Pessoa guilherme = new Pessoa();
            guilherme.nome = "Guilherme";            
            guilherme.endereco.logradouro = "avenida xyz";
                        
            
            //guilherme.endereco.logradouro = "avenida xyz";

            Console.WriteLine(guilherme.endereco.logradouro);

             Console.ReadKey();
        }
    }
}
