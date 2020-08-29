using System.Collections;

namespace SimpleIndexer {
	class PersonCollection : IEnumerable
	{
		private ArrayList people = new ArrayList();

		public Person GetPerson(int pos) { return (Person)people[pos]; }
		public void AddPerson(Person p) { people.Add(p); }
		public void ClearPeople() { people.Clear(); }
		public int Count { get { return people.Count; } }

		IEnumerator IEnumerable.GetEnumerator() { return people.GetEnumerator(); }
	}
}
