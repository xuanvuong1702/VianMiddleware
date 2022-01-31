using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VianMiddleware.Core;

namespace VianMiddlewareTest.Middleware
{
    internal class ManipulateMessageMiddleware: IMiddleware
    {
        public Task InvokeAsync(ITaskContext context, MiddlewareDelegate next)
        {
            context.Headers.Add("manu" + Guid.NewGuid().ToString(), DateTime.Now.ToString());

            return next(context);
        }
    }


}
