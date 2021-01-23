using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathServiceLib {

	public class MathService : IBasicMath {
		public int Add(int x, int y) {
			System.Threading.Thread.Sleep(3000);
			return x + y;
		}
	}
}
