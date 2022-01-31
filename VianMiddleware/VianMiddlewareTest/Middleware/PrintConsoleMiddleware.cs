using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VianMiddleware.Core;

namespace VianMiddlewareTest.Middleware
{
    public class PrintConsoleMiddleware: IMiddleware
    {
        public Task InvokeAsync(ITaskContext context, MiddlewareDelegate next)
        {
            context.Headers.Add("print" + Guid.NewGuid().ToString(), DateTime.Now.ToString());

            return next(context);
        }
    }
}
