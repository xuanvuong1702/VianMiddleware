using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VianMiddleware.Core;

namespace VianMiddleware
{
    public class MiddlewareExecutor : IMiddlewareExecutor
    {
        private IReadOnlyList<IMiddleware> middlewares;
        private ITaskResultHandler _resultHandler;

        public MiddlewareExecutor(ITaskResultHandler resultHandler)
        {
            _resultHandler = resultHandler;
        }

        public Task Execute(ITaskContext context, Func<ITaskContext, Task> nextOperation, IReadOnlyList<IMiddleware> middlewares)
        {
            this.middlewares = middlewares;
            return this.ExecuteDefinition(
                0,
                context,
                nextOperation,
                middlewares);
        }


        private Task ExecuteDefinition(
            int index,
              ITaskContext context,
            Func<ITaskContext, Task> nextOperation,
            IReadOnlyList<IMiddleware> middlewares)
        {
            if (this.middlewares.Count == index)
            {
                return _resultHandler.HandleAsync(context);
            }

            return this.middlewares[index]
                .InvokeAsync(
                    context,
                    nextContext => this.ExecuteDefinition(
                        index + 1,
                        nextContext.Clone(),
                        nextOperation, middlewares));
        }


    }
}
