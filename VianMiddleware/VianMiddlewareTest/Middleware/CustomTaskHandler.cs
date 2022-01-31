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
        private ITaskContext _context;
        public CustomTaskHandler(ITaskContext context)
        {
            _context = context;
        }

        public Task HandleAsync(ITaskContext context)
        {
            var header = context.Headers;
            _context.Message = "changed";
            return Task.CompletedTask;
        }
    }
}
