using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCore.CAP.Messages
{
    public interface IMessageContext
    {
        public IDictionary<string, string> Headers { get; set; }

        public object Value { get; set; }

        IMessageContext Clone();
    }
}
