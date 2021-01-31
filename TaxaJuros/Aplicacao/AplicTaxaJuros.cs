namespace TaxaJuros.Aplicacao
{
    public class AplicTaxaJuros : IAplicTaxaJuros
    {
        public AplicTaxaJuros()
        {
        }

        public decimal TaxaJuros()
        {
            return 0.01M;
        }
    }
}
