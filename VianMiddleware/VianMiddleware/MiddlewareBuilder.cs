using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VianMiddleware.Core;

namespace VianMiddleware
{
    public class MiddlewareBuilder : IMiddlewareBuilder
    {
        private readonly ConcurrentBag<IMiddleware> _middlewares;
        private IMiddlewareExecutor _executor;
        private readonly ITaskContext _taskContext;

        public MiddlewareBuilder(IMiddlewareExecutor executor, ITaskContext taskContext)
        {
            _middlewares = new ConcurrentBag<IMiddleware>();
            _executor = executor;
            _taskContext = taskContext;
        }

        public void UseMiddleware<T>()
            where T : class, IMiddleware
        {
            T obj = (T)Activator.CreateInstance(typeof(T));

            this._middlewares.Add(obj);
        }

        public IList<IMiddleware> GetMiddlewares()
        {
            return this._middlewares.ToList();
        }

        public async Task RunPipeline()
        {
            await _executor.Execute(_taskContext, _ => Task.CompletedTask, _middlewares.ToList())
                                    .ConfigureAwait(false);

        }

        public async Task RunPipeline(ITaskContext context)
        {
            await _executor.Execute(context, _ => Task.CompletedTask, _middlewares.ToList())
                                    .ConfigureAwait(false);

        }

    }
}
