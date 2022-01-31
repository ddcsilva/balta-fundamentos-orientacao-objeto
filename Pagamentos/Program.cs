using System;

namespace Pagamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            // private, protected, internal e public

            var pagamento = new Pagamento();

            Console.WriteLine(pagamento.Vencimento);
            pagamento.Vencimento = DateTime.Now;
            Console.WriteLine(pagamento.Vencimento);
        }

        public class Pagamento
        {
            // Propriedades
            private DateTime _vencimento;
            public DateTime Vencimento
            {
                get
                {
                    Console.WriteLine("Lendo o valor");
                    return _vencimento;
                }
                set
                {
                    Console.WriteLine("Atribuindo o valor");
                    _vencimento = value;
                }
            }

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
