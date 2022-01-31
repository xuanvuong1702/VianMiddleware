using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VianMiddleware.Core
{
    public interface IMiddlewareBuilder
    {
        public void UseMiddleware<T>() where T : class, IMiddleware;

        public IList<IMiddleware> GetMiddlewares();

        public Task RunPipeline();
    }
}
