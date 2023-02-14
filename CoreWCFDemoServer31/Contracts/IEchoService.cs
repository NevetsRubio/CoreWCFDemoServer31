using CoreWCF;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace CoreWCFDemoServer31.Contracts
{
    [ServiceContract(Namespace = "http://localhost:5031")]
    public interface IEchoService
    {
        [OperationContract]
        string Echo(string text);

        [OperationContract]
        string ComplexEcho(EchoMessage echoMessage);

        [OperationContract]
        [FaultContract(typeof(EchoFault))]
        string FailEcho(string text);

        [OperationContract]
        public string DependencyInjectionExample(string text);
    }

    [DataContract]
    public class EchoMessage
    {
        [AllowNull]
        [DataMember]
        public string Text { get; set; }
    }

    [DataContract]
    public class EchoFault
    {
        [DataMember]
        [AllowNull]
        public string Text { get; set; }
    }
}
