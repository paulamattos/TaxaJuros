using Microsoft.AspNetCore.Mvc;
using TaxaJuros.Aplicacao;

namespace TaxaJuros.Controllers
{
    [Route("taxaJuros")]
    public class TaxaJurosController: ControllerBase
    {
        private readonly IAplicTaxaJuros _aplicTaxaJuros;

        public TaxaJurosController(IAplicTaxaJuros aplicTaxaJuros)
        {
            _aplicTaxaJuros = aplicTaxaJuros;
        }

        [HttpGet]
        public decimal TaxaJuros()
        {
            var ret = _aplicTaxaJuros.TaxaJuros();
            return ret;  
        }
    }
}
