using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {
        }

        // [HttpGet]
        // public Evento Get()
        // {
        //     return new Evento()
        //     {
        //         EventoId = 1,
        //         Tema = "Angular 11 e .NET 5",
        //         Local = "Salvador - BA",
        //         Lote = "1º Lote",
        //         QtdPessoa = 2000,
        //         DataEvento = DateTime.Now.AddDays(5).ToString(),
        //         ImagemURL = "foto.png"
        //     };
        // }
    }
}
