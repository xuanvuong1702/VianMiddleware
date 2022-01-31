using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.MessageMiddleware
{
    public interface IMiddlewareExecutor
    {
        Task Execute(IMessageContext context, Func<IMessageContext, Task> nextOperation);
    }
}
