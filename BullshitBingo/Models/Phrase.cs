using System;

namespace BullshitBingo
{
	public class Phrase
	{
		public string Name { get; set; }
		public bool Set { get; set; }

		public Phrase(string Name, bool Set)
		{
			this.Name = Name;
			this.Set = Set;
		}
	}
}