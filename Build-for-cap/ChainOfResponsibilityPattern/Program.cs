using ChainOfResponsibilityPattern.MessageMiddleware;
using ChainOfResponsibilityPattern.MessageMiddleware.Middleware;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MiddlewareVersion();
        }


        public static void MiddlewareVersion()
        {
            ConsumerMessageContext messageContext = new ConsumerMessageContext("ahihi");

            ConsoleMiddleware consoleMiddleware = new ConsoleMiddleware();
            AddTextMiddleware addTextMiddleware = new AddTextMiddleware();


            List<IMessageMiddleware> messageMiddlewares = new List<IMessageMiddleware>();

            messageMiddlewares.Add(consoleMiddleware);
            messageMiddlewares.Add(addTextMiddleware);

            IReadOnlyList<IMessageMiddleware> middlewares = new ReadOnlyCollection<IMessageMiddleware>(messageMiddlewares);

            MiddlewareExecutor middlewareExecutor = new MiddlewareExecutor(middlewares);


            middlewareExecutor
                              .Execute(messageContext, _ => Task.CompletedTask)
                                    .ConfigureAwait(false);


        }
    }

}