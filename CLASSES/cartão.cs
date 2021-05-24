using System;

namespace lógica.CLASSES
{
    public abstract class cartão : Pagamento
    {
        public string Bandeira;
        public string Numero;
        public string Titular;
        public string Cvv;

        public string SalvarCartão()
        {

            Console.WriteLine("Digite a bandeira do cartão");
            Bandeira = Console.ReadLine();

            Console.WriteLine("Digite a numeração do cartão");
            Numero = Console.ReadLine();

            Console.WriteLine("Digite o titular do cartão");
            Titular = Console.ReadLine();

            Console.WriteLine("Digite o CVV do cartão");
            Cvv = Console.ReadLine();

            return $"Cartão de número {Numero} salvo com sucesso!!!";
        }
    }
}