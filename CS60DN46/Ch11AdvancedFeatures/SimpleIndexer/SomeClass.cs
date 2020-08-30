using System.Collections.Generic;
using System.Collections;

namespace SimpleIndexer {
	class SomeClass : IStringContainer, IEnumerable {
		private List<string> myStrings = new List<string>();

		public string this[int index] {
			get { return myStrings[index]; }
			set { myStrings.Insert(index, value); }
		}

		public void Clear() { myStrings.Clear(); }
		public int Count { get { return myStrings.Count; } }

		IEnumerator IEnumerable.GetEnumerator() { return myStrings.GetEnumerator(); }
	}
}
