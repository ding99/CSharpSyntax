using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

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
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Observable collection");

			ObservableCollection<Person> people = new ObservableCollection<Person>
			{
				new Person{ FirstName="Peter", LastName="Murphy", Age=52},
				new Person{ FirstName="Kevin", LastName="Key", Age=48},
			};
			display(people, "original");

			people.CollectionChanged += people_CollectionChanged;

			Person newPerson = new Person { FirstName = "Jason", LastName = "Pu", Age = 35 };
			Console.WriteLine($"-   add <{newPerson}>");
			people.Add(newPerson);
			display(people, "modified");

			Console.WriteLine($"-   remove the 2nd item");
			people.RemoveAt(1);
			display(people, "modified");

			Console.WriteLine($"-   clear");
			people.Clear();
			display(people, "modified");
		}

		static void display(ObservableCollection<Person> list, string msg)
		{
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine($"-> {msg} collection:");
			if(list.Count > 0)
			foreach (var a in list)
				Console.WriteLine($"   {a}");
			else Console.WriteLine("   <no items>");
			Console.BackgroundColor = ConsoleColor.Black;
		}

		static void people_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			Console.WriteLine($"--- Action {e.Action}; OldStart {e.OldStartingIndex} / NewStart {e.NewStartingIndex}");
			switch (e.Action)
			{
				case NotifyCollectionChangedAction.Add:
					foreach (var a in e.NewItems)
						Console.WriteLine($"  NewItem <{a}>");
					break;
				case NotifyCollectionChangedAction.Remove:
					foreach (var a in e.OldItems)
						Console.WriteLine($"  OldItem <{a}>");
					break;
			}
		}
	}
}
