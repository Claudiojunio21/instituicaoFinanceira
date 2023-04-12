using System;


class Conta
{
    private int numero;
    private decimal saldo;
    private Cliente titular;


    // Variável estática para rastrear o saldo inicial total geral
    private static decimal saldoInicialTotalGeral;

    // Construtor que adiciona o saldo inicial da nova conta à variável estática
    public Conta(decimal saldoInicial, int numero, string Cliente)
    {
        if (saldoInicial < 10.0m) //Modifique a classe conta, de modo que somente seja possível criar objetos que deveão ser superior a R$10,00.
        {
            throw new ArgumentException("O saldo inicial não pode ser inferior a R$10,00."); //Caso o valor de saldo inicial seja inferior ao permitido o usuário deverá ser notificado.
        }

        if (String.IsNullOrEmpty(Cliente)) // Verifica se titular é nulo ou vazio
        {
            throw new ArgumentException("O titular da conta é obrigatório.");
        }

        this.numero = numero;
        saldo = saldoInicial;
        saldoInicialTotalGeral += saldoInicial;

    }

    public int Numero
    {
        get => numero;
        set => numero = value;
    }

    public int NumeroProp { get; set; }

    public decimal SaldoProp
    {
        get { return saldo; }
        set
        {
            if (value >= 0.0m)
            {
                saldo = value;
            }
            else
            {
                Console.WriteLine("O saldo não pode ser definido como negativo.");
            }
        }
    }

    // Método estático para obter o número da conta com o maior saldo
    //Ao final deverá ser informado o número da conta que possui o maior saldo (deve ser possível obter o maior saldo por meio de qualquer instancia de Conta);
    public static int NumeroContaComMaiorSaldo()
    {

        Conta[] contas = { new Conta(1235.42m, 123456, "Fulano"),
                           new Conta(2341.42m, 654321, "Sicrano")};

        decimal maiorSaldo = contas[0].SaldoProp;
        int numeroContaMaiorSaldo = contas[0].Numero;

        for (int i = 1; i < contas.Length; i++)
        {
            if (contas[i].SaldoProp > maiorSaldo)
            {
                maiorSaldo = contas[i].SaldoProp;
                numeroContaMaiorSaldo = contas[i].Numero;
            }
        }

        return numeroContaMaiorSaldo;
    }

    // Propriedade estática para obter o saldo inicial total geral
    //Ao final deverá ser informado o saldo inicial total geral. A cada alteração do saldo ele será alterado.
    public static decimal SaldoInicialTotalGeral
    {
        get { return saldoInicialTotalGeral; }
    }

    public void Deposito(decimal valor)
    {
        if (valor > 0)
        {
            SaldoProp += valor;
        }
    }

    //Crie um método saque na classe Conta
    public decimal Saque(decimal valor)
    {
        if (valor > 0 && valor <= saldo)
        {
            saldo -= valor;
            saldo -= 0.1m; // Deduz a taxa do saldo da conta
        }
        else
        {
            Console.WriteLine("Saldo não pode ser inferior a 0.");
        }
        return saldo;
    }

    //ser possível realizar a transferência entre contas
    public void Transferencia(decimal valor, Conta contaDestino)
    {
        if (valor > 0 && valor <= saldo && contaDestino != null)
        {
            saldo -= valor;
            contaDestino.saldo += valor;
            Console.WriteLine("Transferência realizada com sucesso.");
            Console.WriteLine("Saldo atual da conta {0}: R${1}", titular, saldo);
            Console.WriteLine("Saldo atual da conta de destino ({0}): R${1}", contaDestino.titular, contaDestino.saldo);
        }
        else
        {
            Console.WriteLine("Não foi possível realizar a transferência.");
        }
    }
}
