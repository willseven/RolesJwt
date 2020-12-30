using System.Threading.Tasks;
using Aplicacion.Seguridad;
using Dominio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class UsuarioController : MiControllerBase
    {
        [AllowAnonymous]
        //Http://localhost:5000/api/Usuario/login
        [HttpPost("Login")]
        public async Task<ActionResult<UsuarioData>> Login(Login.Ejecuta parametros)
        {
            return await Mediator.Send(parametros);
        }
        //Http://localhost:5000/api/Usuario/registrar
        [HttpPost("Registrar")]
        public async Task<ActionResult<UsuarioData>> Registrar(Registrar.Ejecuta parametros){
            return await Mediator.Send(parametros);
        }

        [HttpGet]
        public async Task<ActionResult<UsuarioData>> DevolverUsuario(){
            return await Mediator.Send(new UsuarioActual.Ejecutar());
        }
    }
}