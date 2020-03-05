
using Microsoft.AspNetCore.Mvc;
using Senai.InLock.WebApi.Interfaces;
using Senai.InLock.WebApi.Repositories;


namespace Senai.InLock.WebApi.Controllers
{
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

      
        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            //UsuarioRepository usuarios = _usuarioRepository.BuscarPorConta();

        }
    }
}