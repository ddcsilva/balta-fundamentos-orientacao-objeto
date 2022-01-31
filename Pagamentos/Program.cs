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
            DateTime Vencimento;
            Endereco EnderecoCobranca;

            // Métodos
            void Pagar() { }
        }

        public class Endereco
        {
            public string CEP;
        }
    }
}
