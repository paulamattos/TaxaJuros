using Moq;
using TaxaJuros.Aplicacao;
using TaxaJuros.Controllers;
using Xunit;

namespace TaxaJuros.Test.Controllers
{
    public class TaxaJurosControllerTest
    {
        [Fact]
        public void TaxaJurosDeveRetornar0_01()
        {
            var mockAplicTaxaJuros = new Mock<IAplicTaxaJuros>();
            mockAplicTaxaJuros.Setup(p => p.TaxaJuros()).Returns(0.01m);         
            var controller = new TaxaJurosController(mockAplicTaxaJuros.Object);
            var taxaJuros = controller.TaxaJuros();
            Assert.Equal(0.01m, taxaJuros);
        }
    }
}
