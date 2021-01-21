using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using MagicEightBallServiceClientVS.ServiceReference1;

namespace MagicEightBallServiceClientVS {
	class Program {
		static void Main() {
			Console.WriteLine("***** Ask the Magic 8 Ball (VS) *****");

			using (EightBallClient ball = new EightBallClient()) {
				Console.WriteLine("Your question: ");
				string question = Console.ReadLine();
				string answer = ball.ObtainAnswerToQuestion(question);
				Console.WriteLine($"Question : {question}");
				Console.WriteLine($"Answer   : {answer}");
			}
		}
	}
}
