using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Senai.InLock.WebApi.Interfaces;
using Senai.InLock.WebApi.Repositories;

namespace Senai.InLock.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]

    [ApiController]
    public class JogosController : Controller
    {

        private IJogosRepository _jogosRepository { get; set; }

        public JogosController()
        {
            _jogosRepository = new JogosRepository();
}
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult ListarJogos()
        {
          

            return Ok(_jogosRepository.Listar());
        }
    }
}