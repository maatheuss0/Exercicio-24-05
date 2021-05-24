using System;

namespace lógica.CLASSES
{
    public class crédito : cartão
    {
        private float limite = 3000f;

        public void pagar()
        {

            float valor = this.Valor;
            int vezes;

            if (valor > limite)
            {
                Console.WriteLine("Faltou limite eim jovem!");
            }

            else
            {

                do
                {

                    Console.WriteLine($"Deseja parcelar em quantas vezes o valor {valor:C2}? (De 1 à 12 vezes)");
                    vezes = int.Parse(Console.ReadLine());

                    if (vezes >= 1 && vezes <= 6)
                    {
                        Console.WriteLine($"Você optou em parcelar em {vezes}, dessa forma o juros será de 5% do valor");
                        Console.WriteLine($"Você irá pagar {valor * 1.05:C2} em {vezes} de {(valor * 1.05) / vezes:C2}");
                    }

                    else if (vezes >= 7 && vezes <= 12)
                    {
                        Console.WriteLine($"Você optou em parcelar em {vezes}, dessa forma o juros será de 8% do valor");
                        Console.WriteLine($"Você irá pagar {valor * 1.08:C2} em {vezes} de {(valor * 1.08) / vezes:C2}");
                    }

                    else
                    {
                        Console.WriteLine($"Impossivel parcelar nessa quantidade!, Escolha um número de vezes indicado");

                    }
                } while (vezes > 12 || vezes < 1);
            }

        }

    }
}