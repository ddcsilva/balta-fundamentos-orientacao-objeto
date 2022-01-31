using System;

namespace Pagamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            // private, protected, internal e public

            var pagamento = new Pagamento();
            var pagamentoCartao = new PagamentoCartaoCredito();
            pagamento.Pagar("12");
            pagamentoCartao.Pagar("123");
        }

        public class Pagamento
        {
            public Pagamento()
            {
                Console.WriteLine("Iniciando Pagamento");
            }

            // Propriedades
            DateTime Vencimento;
            Endereco EnderecoCobranca;

            // Métodos
            public virtual void Pagar(string numero)
            {
                Console.WriteLine("Pagar");
            }
            void Pagar(string numero, DateTime vencimento, bool pagarAposVencimento = false) { }
        }

        public class PagamentoCartaoCredito : Pagamento
        {
            public string CEP;

            public override void Pagar(string numero)
            {
                Console.WriteLine("Pagar com Cartão");
            }
        }

        public class Endereco
        {
            public string CEP;
        }
    }
}
