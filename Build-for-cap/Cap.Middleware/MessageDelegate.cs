﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.MessageMiddleware
{
    public delegate Task MiddlewareDelegate(IMessageContext context);
}
