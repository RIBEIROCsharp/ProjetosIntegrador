using AlugaCar.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        [HttpGet("{placa}")]
        public IEnumerable<Model.Carros> GetPlaca(string placa)
        {
            Model.CamadaDeAcessoDados acessoBD = new Model.CamadaDeAcessoDados();
            List<Model.Carros> listCarros = acessoBD.GetPlaca(placa);

            return listCarros;
        }

        [HttpPost]
        public void SetCarro(Carros carro)
        {
           
            Model.CamadaDeAcessoDados acessoBD = new Model.CamadaDeAcessoDados();
            acessoBD.CadastraCarros(carro);

        }
        [HttpDelete]
        public void DeleteCar(Carros carro)
        {
            Model.CamadaDeAcessoDados acessoBD = new Model.CamadaDeAcessoDados ();
            acessoBD.DeleteCarros(carro);
        }
    }
}
