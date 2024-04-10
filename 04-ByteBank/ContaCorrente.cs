

public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;
    public bool ativo;


    // Quando o metodo retorna um valor como no caso abaixo é considerado função mas não é errado chamar metodo
    public bool Sacar(double valor) // Toda função ela representa uma ação (Sacar = verbo Infinitivo)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }

    // Quando o metodo não retorna nada como no caso void chamamos de metodo mesmo.
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }
    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this.saldo < valor)
            return false;
        else
            this.saldo -= valor;
        contaDestino.Depositar(valor);
        return true;
    }
}




