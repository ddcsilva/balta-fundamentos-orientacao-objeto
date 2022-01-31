using System;

namespace Pagamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Pagar();
            pagamentoBoleto.Vencimento = DateTime.Now;
            pagamentoBoleto.NumeroBoleto = "123";

            var pagamentoCartaoCredito = new PagamentoCartaoCredito();
            pagamentoCartaoCredito.Pagar();
            pagamentoCartaoCredito.Vencimento = DateTime.Now;
            pagamentoCartaoCredito.NumeroCartao = "321";

            var pagamento = new Pagamento();
            pagamento.Vencimento = Convert.ToDateTime("2022-01-01");
            Console.WriteLine(pagamento.ToString());
        }

        class Pagamento
        {
            // Propriedades
            public DateTime Vencimento;

            // Métodos
            public virtual void Pagar() { }

            public override string ToString()
            {
                return Vencimento.ToString("dd/MM/yyyy");
            }
        }

        class PagamentoBoleto : Pagamento
        {
            public string NumeroBoleto;

            public override void Pagar()
            {
                // Regra do Boleto
                Console.WriteLine("Pagamento Realizado com Boleto!");
            }
        }

        class PagamentoCartaoCredito : Pagamento
        {
            public string NumeroCartao;

            public override void Pagar()
            {
                // Regra do Cartão de Crédito
                Console.WriteLine("Pagamento Realizado com Cartão de Crédito!");
            }
        }
    }
}
