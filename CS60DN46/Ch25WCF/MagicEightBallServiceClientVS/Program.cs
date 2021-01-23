using MagicEightBallServiceClientVS.ServiceReference1;
using System;

namespace MagicEightBallServiceClientVS {
	class Program {
		static void Main() {
			Console.WriteLine("***** Ask the Magic 8 Ball (VS) *****");

//			using (EightBallClient ball = new EightBallClient()) {
			using (EightBallClient ball = new EightBallClient("BasicHttpBinding_IEightBall")) {
					Console.WriteLine("Your question: ");
				string question = Console.ReadLine();
				string answer = ball.ObtainAnswerToQuestion(question);
				Console.WriteLine($"Question : {question}");
				Console.WriteLine($"Answer   : {answer}");
			}
		}
	}
}
