using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        // 0 - funcionario
        // 1 - Diretor
        // 2 - Designer
        public static int TotalDeFuncionarios { get; private set; }

        //private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        //public string Senha { get; set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");
            Salario = salario;
            CPF = cpf;
            TotalDeFuncionarios++;
        }
        public abstract void AumentarSalario();
        public abstract double GetBonificacao(); // Convenção // era Virtual agora as classes filhas precisam sobrescrever 
    }
}
