using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.MessageMiddleware.Middleware
{
    public class AddTextMiddleware : IMessageMiddleware
    {
        public Task Invoke(IMessageContext context, MiddlewareDelegate next)
        {
            Console.WriteLine("Hanlder text in AddTextMiddleware!");
            Console.WriteLine("before: " + context.Message);
            context.Message = "add some text" + context.Message;
            Console.WriteLine("after: " + context.Message);
            return next(context);
        }
    }
}
