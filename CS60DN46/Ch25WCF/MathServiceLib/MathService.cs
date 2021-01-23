namespace MathServiceLib {

	public class MathService : IBasicMath {
		public int Add(int x, int y) {
			System.Threading.Thread.Sleep(3000);
			return x + y;
		}
	}
}
