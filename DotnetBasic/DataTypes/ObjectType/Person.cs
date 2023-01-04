using System;
namespace DataTypes.ObjectType
{
	public class Person
	{
		public String Name { get; set; }
		public Int32 Age { get; set; }

		public Person(String name, int age)
		{
			this.Name = name;
			this.Age = age;
		}
	}
}

