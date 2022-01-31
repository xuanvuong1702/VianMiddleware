using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using VianMiddleware.Core;

namespace VianMiddleware
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMiddleware(this IServiceCollection services, Action<MiddlewareOptions> setupAction) 
        { 
            services.AddSingleton<ITaskResultHandler, TaskResultHandler>();
            services.AddSingleton<IMiddlewareExecutor, MiddlewareExecutor>();
            services.AddSingleton<IMiddlewareBuilder, MiddlewareBuilder>();

            return services;
        }

        public static IServiceCollection AddCustomTaskResultHandler<TTaskResultHandler>(this IServiceCollection services)
            where TTaskResultHandler : class, ITaskResultHandler
            
        {
            services.AddSingleton<ITaskResultHandler, TTaskResultHandler>();

            return services;
        }

        public static void UseMiddleware<T>(this MiddlewareBuilder builder)
        {
            builder.UseMiddleware<T>();
        }
    }
}
