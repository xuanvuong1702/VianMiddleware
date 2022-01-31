using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VianMiddleware.Core
{
    public interface ITaskResultHandler
    {
        public Task HandleAsync(ITaskContext context);
    }
}
