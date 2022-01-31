using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.MessageMiddleware
{
    public interface IMessageMiddleware
    {
        Task Invoke(IMessageContext context, MiddlewareDelegate next);
    }
}
