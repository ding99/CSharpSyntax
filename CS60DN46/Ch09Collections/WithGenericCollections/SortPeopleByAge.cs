using System.Collections.Generic;

namespace WithGenericCollections
{
	class SortPeopleByAge : IComparer<Person>
	{
		public int Compare(Person first, Person secnod)
		{
			return first.Age > secnod.Age ? 1 : first.Age < secnod.Age ? -1 : 0;
		}
	}
}
