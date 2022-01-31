using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VianMiddleware.Core
{
    public interface IMiddleware
    {
        Task InvokeAsync(ITaskContext context, MiddlewareDelegate next);
    }
}
