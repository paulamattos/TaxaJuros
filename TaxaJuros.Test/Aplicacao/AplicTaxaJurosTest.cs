using TaxaJuros.Aplicacao;
using Xunit;

namespace TaxaJuros.Test.Aplicacao
{
    public class AplicTaxaJurosTest
    {
        [Fact]
        public void TaxaJurosDeveRetornar0_01()
        {
            var aplic = new AplicTaxaJuros();
            var taxaJuros = aplic.TaxaJuros();
            Assert.Equal(0.01m, taxaJuros);
        }
    }
}
