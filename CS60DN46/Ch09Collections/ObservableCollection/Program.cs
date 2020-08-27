using System;
using System.Collections.ObjectModel;

namespace ObservableCollection
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Observable Collectoins *****");
			Observable();
			Console.ResetColor();
		}

		static void Observable()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Observable collection");

			ObservableCollection<Person> people = new ObservableCollection<Person>
			{
				new Person{ FirstName="Peter", LastName="Murphy", Age=52},
				new Person{ FirstName="Kevin", LastName="Key", Age=48},
			};

			Console.WriteLine("-> original collection:");
			foreach(var a in people)
				Console.WriteLine(a);

			people.CollectionChanged += people_CollectionChanged;

			Person newPerson = new Person { FirstName = "Jason", LastName = "Pu", Age = 35 };
			Console.WriteLine($"-  add <{newPerson}>");
			Console.WriteLine($"-  remove the 2nd item");
			people.Add(newPerson);
			people.RemoveAt(1);
			Console.WriteLine("-> modified collection:");
			foreach (var a in people)
				Console.WriteLine(a);
		}

		static void people_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			Console.WriteLine($"#### Action {e.Action}");
			//throw new NotImplementedException();
		}
	}
}
