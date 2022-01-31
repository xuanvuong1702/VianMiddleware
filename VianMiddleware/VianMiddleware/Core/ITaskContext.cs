using System;
using System.Collections.Generic;
using System.Text;

namespace VianMiddleware.Core
{
    public interface ITaskContext
    {
        public string Message { get; set; }

        public IDictionary<string, string> Headers {  get; set; }

        ITaskContext Clone();
    }
}
