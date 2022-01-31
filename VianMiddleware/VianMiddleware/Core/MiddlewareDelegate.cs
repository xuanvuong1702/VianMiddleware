using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VianMiddleware.Core
{
    public delegate Task MiddlewareDelegate(ITaskContext context);
}
