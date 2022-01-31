using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VianMiddleware.Core;

namespace VianMiddlewareTest.Middleware
{
    public class CustomTaskHandler : ITaskResultHandler
    {
        public Task HandleAsync(ITaskContext context)
        {
            var header = context.Headers;
            return Task.CompletedTask;
        }
    }
}
