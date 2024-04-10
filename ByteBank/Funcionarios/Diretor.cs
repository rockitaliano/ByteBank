using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        //public string Senha { get; set; }
        public Diretor(double salario, string cpf) : base (salario, cpf)
        {
            Console.WriteLine("Criando Diretor");
        }
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public override double GetBonificacao() // Convenção // override = subescrevendo o getBon da classe Base Funcionario
        {
            //return Salario;
            return Salario * 0.5;
        }
        

    }
}
