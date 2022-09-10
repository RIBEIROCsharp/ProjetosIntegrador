using AlugaCar.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public IEnumerable<Model.Aluguel> GetAluguel(int cod_aluguel)
        {
            Model.CamadaDeAcessoDados acessoBD = new Model.CamadaDeAcessoDados();
            List<Model.Aluguel> listCodAluguel = acessoBD.GetCodAluguel(cod_aluguel);

            return listCodAluguel;
        }

        [HttpPost]
        public void SetAluguel(Aluguel aluguel) 
        {

            Model.CamadaDeAcessoDados acessoBD = new Model.CamadaDeAcessoDados();
            acessoBD.CadastraAluguel(aluguel);

        }
        [HttpDelete]
        public void DeleteAlugel(Aluguel aluguel)
        {
            Model.CamadaDeAcessoDados acessoBD = new Model.CamadaDeAcessoDados();
            acessoBD.DeleteAluguel(aluguel);
        }
    }
}
