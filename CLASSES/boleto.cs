using System;

namespace lógica.CLASSES
{
    public class boleto : Pagamento
    {
        private string CódigoBarras;
        Random r = new Random();

        public void Registar()
        {
            CódigoBarras = r.Next(300000).ToString();
            Console.WriteLine($"Boleto gerado com o código {CódigoBarras}");
            Console.WriteLine($"Boleto registrado com desconto, PARABÉNS! o valor atual é de {this.Valor * 0.88:C2}!");
        }
    }
}