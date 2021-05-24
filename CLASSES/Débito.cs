using System;

namespace lógica.CLASSES
{
    public class Débito : cartão
    {
        private float Saldo = 10600f;

        public void Pagar()
        {
            float valor = this.Valor;

            if (valor > Saldo)
            {
                Console.WriteLine("Você não possui saldo suficiente");
            }

            else 
            {
                Console.WriteLine($"O valor de {valor:C2} foi pago com êxito");
            }
        } 
    }
}