using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using VianMiddleware;
using VianMiddleware.Core;
using VianMiddlewareTest.Context;
using VianMiddlewareTest.Middleware;

namespace VianMiddlewareTest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {


            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddScoped<ITaskContext, TaskContext>()

                .AddMiddleware(option => {
                    option.Name = "";
                })
                .AddCustomTaskResultHandler<CustomTaskHandler>()
                .BuildServiceProvider();

            var builder = serviceProvider.GetService<IMiddlewareBuilder>();

            builder.UseMiddleware<ManipulateMessageMiddleware>();
            builder.UseMiddleware<PrintConsoleMiddleware>();

            using (var scope = serviceProvider.CreateScope())
            {
                await builder.RunPipeline();
                var context = serviceProvider.GetServices<ITaskContext>();
            }

        }

    }
}
