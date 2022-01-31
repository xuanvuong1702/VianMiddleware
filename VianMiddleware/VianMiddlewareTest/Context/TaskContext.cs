using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VianMiddleware.Core;

namespace VianMiddlewareTest.Context
{
    public class TaskContext: ITaskContext
    {
        public TaskContext(string content)
        {
            Message = content;
        }
        public TaskContext()
        {
            Message = "default";
            Headers = new Dictionary<string, string>();
        }
        public string Message { get; set; }

        public IDictionary<string, string> Headers { get; set; }

        public object Request { get; set; }
        public object Response { get; set; }

        public ITaskContext Clone() => (ITaskContext)this.MemberwiseClone();
    }
}
