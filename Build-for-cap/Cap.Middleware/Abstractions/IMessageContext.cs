using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern.MessageMiddleware
{
    public interface IMessageContext
    {
        public string Message { get; set; }
        IMessageContext Clone();
    }
}
