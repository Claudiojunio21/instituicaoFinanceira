using System;

namespace controleContas
{
    class Program
    {

        static void Main(string[] args)
        {



            ////Criação da conta1
            //Conta conta1 = new Conta();
            //conta1.NumeroProp = 123456;
            //conta1.SaldoProp = 1235.42m;
            //Console.WriteLine("A conta do numero {0} tem saldo {1:C2}", conta1.NumeroProp, conta1.SaldoProp);

            ////Exercício da Revisão - Modifique o programa anterior de modo que possua uma nova conta;
            /////A nova conta deverá ter onúmero 654321 e o saldo R$2341,42.
            //Conta conta2 = new Conta();
            //conta2.NumeroProp = 654321;
            //conta2.SaldoProp = 2341.42m;
            //Console.WriteLine("A conta do numero {0} tem saldo {1:C2}", conta2.NumeroProp, conta2.SaldoProp);

            //Ao final deverá ser informado O saldo total das duas contas;
            // Exibe o número da conta com o maior saldo (Obter através da instancia Conta)
            Console.WriteLine("A conta com o maior saldo é a conta {0}", Conta.NumeroContaComMaiorSaldo());

            // Exibe o saldo inicial total geral
            Console.WriteLine("O saldo inicial total geral é {0:C2}", Conta.SaldoInicialTotalGeral);

            /*Se não utilizássemos a orientação a objetos e a classe Conta não existisse, 
             * para resolver o mesmo problema teríamos que criar uma variável para cada número de conta e uma variável para cada saldo correspondente. 
             * Se tivéssemos duas contas, teríamos que criar duas variáveis, uma para cada conta. Se tivéssemos 10 contas, teríamos que criar 10 variáveis, 
             * uma para cada conta.*/

            /*Uma forma de vincular a classe Conta com a classe Cliente é adicionando uma propriedade do tipo Cliente na classe Conta, representando o titular da conta.*/


            Cliente cliente = new Cliente();
            cliente.Nome = "Claudio Junio";
            cliente.Cpf = "12345678901";
            cliente.AnoNascimento = 1995;

            cliente.ImprimirDados();

            //Analise como poderíamos vincular a classe conta com a classe cliente, queneste caso seria o titular da conta.
            //Resposta: Criar um tipo de relação "Conta_Client" com as chaves estrangeiras das duas classes.

            //classe Program para que possa trabalhar com o construtor criado aqui.
            //public Conta(int numero)
            //{
            //    this.numero = numero;
            //}


        }
    }
}