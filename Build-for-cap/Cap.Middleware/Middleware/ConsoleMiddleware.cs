using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.MessageMiddleware.Middleware
{
    public class ConsoleMiddleware : IMessageMiddleware
    {
        public Task Invoke(IMessageContext context, MiddlewareDelegate next)
        {
            Console.WriteLine("Hanlder text in Console!");
            return next(context);
        }
    }
}
