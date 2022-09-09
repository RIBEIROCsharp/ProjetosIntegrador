using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AlugaCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class aluguelController : ControllerBase
    {
        public IEnumerable<Model.Aluguel> GetListaDeAlugueis()
        {
            Model.CamadaDeAcessoDados acessoBD = new Model.CamadaDeAcessoDados();
            List<Model.Aluguel> listAlugueis = acessoBD.GetListaDeAlugueis();

            return listAlugueis;
    }


        [HttpGet("{cod_aluguel}")]
        public IEnumerable<Model.Aluguel> GetAluguel(Int32 cod_aluguel)
        {
            Model.CamadaDeAcessoDados acessoBD = new Model.CamadaDeAcessoDados();
            List<Model.Aluguel> listCodAluguel = acessoBD.GetCodAluguel(cod_aluguel);

            return listCodAluguel;
        }
    }
}
