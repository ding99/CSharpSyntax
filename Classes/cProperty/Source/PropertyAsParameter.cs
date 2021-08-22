﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CProperty {

    public class Student {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string code, string name, int age) {
            Code = code; Name = name; Age = age;
		}

        public override string ToString() {
            return $"Code[{Code}] Name[{Name}] Age[{Age}]";
        }
    }

    public class PropertyAsParameter {

		public PropertyAsParameter() {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-- Porperty As Parameter");
        }

        public void Start() {
            IEnumerable<Student> students = new List<Student> {
                new Student("AA", "Mark", 20),
                new Student("BB", "Alic", 22),
                new Student("CC", "Json", 25),
                new Student("CC", "Alic", 28),
            }.ToList();

			Console.WriteLine($"Add members ({students.Count()}): ");
            foreach(var s in students)
				Console.WriteLine($"  {s}");

            foreach(var s in students) {
                if(typeof(Student).GetProperty("Code").GetValue(s).Equals("CC"))
					Console.WriteLine($"<> 1 <> [{s}]");
			}

            foreach (var s in students) {
                if (typeof(Student).GetProperty("Name").GetValue(s).Equals("Alic"))
                    Console.WriteLine($"<> 2 <> [{s}]");
            }
        }
    }
}
