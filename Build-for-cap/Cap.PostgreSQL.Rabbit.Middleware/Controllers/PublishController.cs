using DotNetCore.CAP;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cap.PostgreSQL.Rabbit.Middleware.Controllers
{
    [Route("api/pub")]
    public class PublishController : Controller
    {
        private readonly ICapPublisher _capPublisher;

        public PublishController(ICapPublisher publisher)
        {
            this._capPublisher = publisher;
        }

        [Route("pub-time")]
        public async Task<IActionResult> Publisher()
        {
            await _capPublisher.PublishAsync("simple.rabbit.pub", DateTime.Now);
            return Ok();
        }


        [Route("ping")]
        public async Task<IActionResult> Get()
        {
            return Ok("pong");
        }


    }
}
