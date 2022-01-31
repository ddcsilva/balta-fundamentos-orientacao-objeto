using System;

namespace Pagamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            // private, protected, internal e public

            var pagamento = new Pagamento();
        }

        public class Pagamento
        {
            // Propriedades
            protected DateTime Vencimento;

            // Métodos
            protected void Pagar() { }
        }

        public class PagamentoBoleto : Pagamento
        {
            void Test()
            {
                base.
            }
        }
    }
}
