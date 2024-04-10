//using _05_ByteBank;

using Microsoft.Build.Tasks;
using System;
using System.Windows;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        //private Cliente _titular;
        public Cliente Titular  { get; set; }       
        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo = 100;
        private bool _ativo;

        public double Saldo // Propriedade 
        {
            get { return _saldo; }
            set 
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        //public double ObterSaldo()
        //{
        //    Console.WriteLine($"Seu saldo é {this.saldo} ");
        //    return saldo;
        //}

        //public void DefinirSaldo(double saldo)
        //{
        //    if (this.saldo >= 0)
        //    {
        //        Console.WriteLine("O saldo não pode ser negativo: " + saldo);
        //    }
        //    else
        //    {
        //        this.saldo = saldo;
        //    }
        //}
        // Quando o metodo retorna um valor como no caso abaixo é considerado função mas não é errado chamar metodo
        public bool Sacar(double valor) // Toda função ela representa uma ação (Sacar = verbo Infinitivo)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }

        // Quando o metodo não retorna nada como no caso void chamamos de metodo mesmo.
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
                return false;
            else
                this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
        private int Idade { get; set; }
        public bool EhMaiorDeIdade 
        { 
            get 
            { 
                return Idade >= 18; 
            } 
            set // este set pode ser omitido, como não tem retorno.
            { 
            } 
        }
    }
}



