using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern.MessageMiddleware
{
    public class ConsumerMessageContext : IMessageContext
    {
        public ConsumerMessageContext(string content)
        {
            Message = content;
        }
        public string Message { get; set; }

        public IMessageContext Clone() => (IMessageContext)this.MemberwiseClone();
    }
}
