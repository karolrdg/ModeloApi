using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ModuloApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("datahora")]
        public IActionResult ObterDataHoraAtual()
        {
            var obj = new
            {
                DataHoraAtual = DateTime.Now.ToLongDateString(),
                Saudacao = "Olá, seja bem-vindo à API!"
            };
            return Ok(obj);
        }
        [HttpGet("apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var msg = $"Olá, {nome}, seja bem-vindo!";
            return Ok(new { Mensagem = msg });
        }
    }
}