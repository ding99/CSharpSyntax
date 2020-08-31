using System.Collections;
using System.Collections.Generic;

namespace SimpleIndexer {
	class PersonCollectionDic : IEnumerable {
		private Dictionary<string, Person> people = new Dictionary<string, Person>();

		public Person this[string name] {
			get { return (Person)people[name]; }
			set { people[name] = value; }
		}

		public void ClearPeople() { people.Clear(); }
		public int Count { get { return people.Count; } }
		IEnumerator IEnumerable.GetEnumerator() { return people.GetEnumerator(); }
	}
}
