using System;
using lógica.CLASSES;

namespace lógica
{
    class Program
    {
        static void Main(string[] args)
        {

            bool OpçãoValida = false;
            do
            {

                Console.WriteLine($@"
            Escolha um método de pagamento:

            B - Boleto 
            C- Crédito
            D- Débito
            X- Cancelar Pagamento
            
            ");

                string opção = Console.ReadLine();

                switch (opção)
                {
                    case "B":
                        boleto b = new boleto();
                        b.Registar();
                        OpçãoValida = true;
                        break;

                    case "C":
                        crédito c = new crédito();
                        Console.WriteLine(c.SalvarCartão());
                        c.pagar();
                        OpçãoValida = true;
                        break;

                    case "D":
                        Débito d = new Débito();
                        Console.WriteLine(d.SalvarCartão());
                        d.Pagar();
                        OpçãoValida = true;
                        break;

                    case "X":
                        Pagamento p = new Pagamento();
                        Console.WriteLine(p.cancelar());
                        OpçãoValida = true;
                        break;

                    default:
                        Console.WriteLine("Opção de pagamento inválida!!!");
                        OpçãoValida = false;
                        break;
                }

            } while (!OpçãoValida);

        }
    }
}
