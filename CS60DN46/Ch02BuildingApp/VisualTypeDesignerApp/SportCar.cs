using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisualTypeDesignerApp
{
	public class SportCar : Car
	{
		public string GetPetName()
		{
			petName = "Fred";
			return petName;
		}
	}
}