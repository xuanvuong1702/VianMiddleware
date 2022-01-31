using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VianMiddleware.Core
{
    public interface  IMiddlewareExecutor
    {
        Task Execute(ITaskContext context, Func<ITaskContext, Task> nextOperation, IReadOnlyList<IMiddleware> middlewares);
    }
}
