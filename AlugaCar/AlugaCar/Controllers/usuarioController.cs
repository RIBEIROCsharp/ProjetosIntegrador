using AlugaCar.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AlugaCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usuarioController : ControllerBase
    {
        public IEnumerable<Model.Usuario> GetListaDeUsuarios()
        {
            Model.CamadaDeAcessoDados acessoBD = new Model.CamadaDeAcessoDados();
            List<Model.Usuario> listUsuarios = acessoBD.GetListaDeUsuarios();

            return listUsuarios;
        }


        [HttpGet("{cpf}")]
        public IEnumerable<Model.Usuario> GetUsuario(string cpf)
        {
            Model.CamadaDeAcessoDados acessoBD = new Model.CamadaDeAcessoDados();
            List<Model.Usuario> listUsuarios = acessoBD.GetUsuario(cpf);

            return listUsuarios;
        }

        [HttpPost]
        public void SetUsuario(Usuario usuario)
        {

            Model.CamadaDeAcessoDados acessoBD = new Model.CamadaDeAcessoDados();
            acessoBD.CadastraUsuario(usuario);

        }
        [HttpDelete]
        public void Deleteuser(Usuario usuario)
        {
            Model.CamadaDeAcessoDados acessoBD = new Model.CamadaDeAcessoDados();
            acessoBD.DeleteUsuario(usuario);
        }

    }
}
