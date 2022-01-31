using DotNetCore.CAP;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cap.PostgreSQL.Rabbit.Middleware.Applications
{
    public static class ApplicationConfig
    {
        public static Action<RabbitMQOptions> GetRabbitMQConfigure(IConfiguration configuration)
        {
            var rabbitMQOption = configuration.GetSection("RabbitMQ").Get<RabbitMQOptions>();

            Action<RabbitMQOptions> action = r =>
           {
               r.Port = r.Port;
               r.HostName = r.HostName;
               r.UserName = r.UserName;
               r.Password = r.Password;

           };

            return action;
        }
    }
}
