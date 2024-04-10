using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            // CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();
        }
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor(salario: 5000, "777.777.777-77");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta(salario: 4000, "555.555.555-55");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
            sistemaInterno.Logar(parceiro, "123456");
        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
            //Funcionario funcionario = new Funcionario(1000,"1321"); Classe abstrata

            Designer pedro = new Designer(salario: 3000, "888.888.888-02");
            pedro.Nome = "Pedro";            

            Diretor roberta = new Diretor(salario: 5000, "777.777.777-77");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            Auxiliar igor = new Auxiliar(salario: 2000, "666.666.666-66");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta(salario: 4000, "555.555.555-55");
            camila.Nome = "Camila";
            camila.Senha = "abc";            

            Desenvolvedor guilherme = new Desenvolvedor(salario: 3000, "555.555.555-55");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(guilherme);

            Console.WriteLine("Total de bonificação do mês: " + gerenciadorBonificacao.GetTotalBonificacao());
        }

    }
}
