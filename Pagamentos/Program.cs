using System;

namespace Pagamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        class Pagamento
        {
            DateTime Vencimento;

            void Pagar()
            {
                ConsultarSaldoDoCartao();
            }

            private void ConsultarSaldoDoCartao()
            {

            }
        }
    }
}
