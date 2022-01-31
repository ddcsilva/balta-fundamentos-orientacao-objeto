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
            pagamentoBoleto.Pagar();
            pagamentoBoleto.Vencimento = DateTime.Now;
            pagamentoCartaoCredito.NumeroCartao = "321";

            Console.WriteLine("Hello World!");
        }

        class Pagamento
        {
            public DateTime Vencimento;

            public void Pagar() { }
        }

        class PagamentoBoleto : Pagamento
        {
            public string NumeroBoleto;
        }

        class PagamentoCartaoCredito : Pagamento
        {
            public string NumeroCartao;
        }
    }
}
