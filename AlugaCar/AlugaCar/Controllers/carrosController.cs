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
    public class carrosController : ControllerBase
    {
        public IEnumerable<Model.Carros> GetListaDeCarros()
        {
            Model.CamadaDeAcessoDados acessoBD = new Model.CamadaDeAcessoDados();
            List<Model.Carros> listCarros = acessoBD.GetListaDeCarros();


            return listCarros;
        }
    }
}
