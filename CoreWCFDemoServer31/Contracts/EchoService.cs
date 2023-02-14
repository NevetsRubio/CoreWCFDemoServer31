using CoreWCF;
using Microsoft.Extensions.Logging;
using System;

namespace CoreWCFDemoServer31.Contracts
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public partial class EchoService : IEchoService
    {
        public string Echo(string text)
        {
            Console.WriteLine($"[Echo] Recieved {text} from client!");
            return text;
        }

        public string ComplexEcho(EchoMessage echoMessage)
        {
            Console.WriteLine($"[ComplexEcho] Received {echoMessage.Text} from client!");
            return echoMessage.Text;
        }

        public string FailEcho(string text)
        {
            throw new FaultException<EchoFault>(new EchoFault() { Text = "WCF Fault OK" }, new FaultReason("FailReason"));
        }

        public string DependencyInjectionExample(string text, [Injected] ISomeDependency _someDependency, [Injected] ILogger<EchoService> _logger)
        {
            _logger.LogInformation("At least the logger injection worked.");
            if (_someDependency.ShouldContinue())
            {
                Console.WriteLine("It worked.");
            }
            else
            {
                Console.WriteLine("It did not work.");
            }

            return text;
        }
    }
}
