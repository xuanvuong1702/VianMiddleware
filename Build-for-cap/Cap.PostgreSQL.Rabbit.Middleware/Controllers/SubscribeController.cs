using DotNetCore.CAP;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cap.PostgreSQL.Rabbit.Middleware.Controllers
{
    [Route("api/sub")]
    public class SubscribeController : Controller, ICapSubscribe
    {

        [CapSubscribe("simple.rabbit.pub")]
        public void ReceiveMessage(DateTime time)
        {
            Console.WriteLine(time.ToString());
        }

        [Route("ping")]
        public async Task<IActionResult> Get()
        {
            return Ok("pong");
        }
    }
}
