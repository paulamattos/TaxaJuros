using Newtonsoft.Json;
using System.Threading.Tasks;
using Xunit;

namespace TaxaJuros.Test.Integracao.Tests
{
    public class TaxaJurosTest
    {
        private readonly TestContext _testContext;
        private readonly string _controller = "/taxaJuros";

        public TaxaJurosTest()
        {
            _testContext = new TestContext();
        }

        [Fact]
        public async Task TaxaJuros_DeveRetornar0_01()
        {
            var response = await _testContext.Client.GetAsync(_controller);

            response.EnsureSuccessStatusCode();

            var taxa = JsonConvert.DeserializeObject<decimal>(await response.Content.ReadAsStringAsync());

            Assert.Equal(0.01m, taxa);
        }
    }
}
