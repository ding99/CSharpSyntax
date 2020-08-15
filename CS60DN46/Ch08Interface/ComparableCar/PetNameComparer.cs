using System;
using System.Collections;

namespace ComparableCar
{
	class PetNameComparer : IComparer
	{
		int IComparer.Compare(object x, object y)
		{
			Car c1 = x as Car;
			Car c2 = y as Car;
			if (c1 != null && c2 != null)
				return String.Compare(c1.PetName, c2.PetName);
			else throw new ArgumentException("Parameter is not a Car!");
		}
	}
}
