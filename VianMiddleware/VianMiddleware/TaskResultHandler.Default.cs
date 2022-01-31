using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VianMiddleware.Core;

namespace VianMiddleware
{
    public class TaskResultHandler : ITaskResultHandler
    {
        public async Task HandleAsync(ITaskContext context)
        {
            Console.WriteLine("In  TaskResultHandler default");
            await Task.CompletedTask;
        }
    }
}
