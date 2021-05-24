using System;

namespace lógica.CLASSES
{
    public class Pagamento
    {
        private DateTime Data = DateTime.Now;
        protected float Valor = 2600f;

        public string cancelar()
        {
            return "Pagamento cancelado";
        }
    }
}