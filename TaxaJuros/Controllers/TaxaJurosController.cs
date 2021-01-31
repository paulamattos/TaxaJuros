using Microsoft.AspNetCore.Mvc;
using TaxaJuros.Aplicacao;

namespace TaxaJuros.Controllers
{
    [Route("api/taxaJuros")]
    public class TaxaJurosController: ControllerBase
    {
        public readonly IAplicTaxaJuros _aplicTaxaJuros;

        public TaxaJurosController(IAplicTaxaJuros aplicTaxaJuros)
        {
            _aplicTaxaJuros = aplicTaxaJuros;
        }

        [HttpGet]
        public ActionResult<decimal> TaxaJuros()
        {
            var ret = _aplicTaxaJuros.TaxaJuros();
            return ret;  
        }
    }
}
