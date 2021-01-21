using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MagicEightBallServiceClient {

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://MyCompany.com", ConfigurationName = "IEightBall")]
    public interface IEightBall {

        [System.ServiceModel.OperationContractAttribute(Action = "http://MyCompany.com/IEightBall/ObtainAnswerToQuestion", ReplyAction = "http://MyCompany.com/IEightBall/ObtainAnswerToQuestionResponse")]
        string ObtainAnswerToQuestion(string userQuestion);

        [System.ServiceModel.OperationContractAttribute(Action = "http://MyCompany.com/IEightBall/ObtainAnswerToQuestion", ReplyAction = "http://MyCompany.com/IEightBall/ObtainAnswerToQuestionResponse")]
        System.Threading.Tasks.Task<string> ObtainAnswerToQuestionAsync(string userQuestion);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEightBallChannel : IEightBall, System.ServiceModel.IClientChannel {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EightBallClient : System.ServiceModel.ClientBase<IEightBall>, IEightBall {

        public EightBallClient() {
        }

        public EightBallClient(string endpointConfigurationName) :
                base(endpointConfigurationName) {
        }

        public EightBallClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress) {
        }

        public EightBallClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress) {
        }

        public EightBallClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress) {
        }

        public string ObtainAnswerToQuestion(string userQuestion) {
            return base.Channel.ObtainAnswerToQuestion(userQuestion);
        }

        public System.Threading.Tasks.Task<string> ObtainAnswerToQuestionAsync(string userQuestion) {
            return base.Channel.ObtainAnswerToQuestionAsync(userQuestion);
        }

        static void Main() {
            Console.WriteLine("***** Magic Egith Ball Service Client *****");
            string question = "My Question";
            string answer = new EightBallClient().ObtainAnswerToQuestion(question);
			Console.WriteLine($"Question : {question}");
            Console.WriteLine($"Answer   : {answer}");
        }

    }
}