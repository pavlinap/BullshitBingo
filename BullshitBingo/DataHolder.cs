using System;
using System.Collections.Generic;
using BullshitBingo;

namespace BullshitBingo
{
	public class DataHolder
	{
		public static DataHolder Current;

		public List<Phrase> phrases { get; set; }


		public DataHolder ()
		{
			phrases = new List<Phrase> ();

			phrases.Add (new Phrase ("USP", false));
			phrases.Add (new Phrase ("Micro services", false));
			phrases.Add (new Phrase ("Win-Win", false));
			phrases.Add (new Phrase ("Time to market", false));
			phrases.Add (new Phrase ("Perfor-mance", false));
			phrases.Add (new Phrase ("Scalable", false));
			phrases.Add (new Phrase ("Portfolio", false));
			phrases.Add (new Phrase ("24/7", false));
			phrases.Add (new Phrase ("New econo-my", false));
			phrases.Add (new Phrase ("Niche", false));
			phrases.Add (new Phrase ("Upside", false));
			phrases.Add (new Phrase ("Revenue", false));
			phrases.Add (new Phrase ("Supply chain", false));
			phrases.Add (new Phrase ("Call", false));
			phrases.Add (new Phrase ("Web 2.0", false));
			phrases.Add (new Phrase ("The new Face-book", false));
			phrases.Add (new Phrase ("Market share", false));
			phrases.Add (new Phrase ("Stake-holder", false));
			phrases.Add (new Phrase ("Inves-tors", false));
			phrases.Add (new Phrase ("VC", false));
			phrases.Add (new Phrase ("Burn rate", false));
			phrases.Add (new Phrase ("Work group", false));
			phrases.Add (new Phrase ("Market leader", false));
			phrases.Add (new Phrase ("Work load", false));
			phrases.Add (new Phrase ("Work-Life balance", false));

			phrases.Shuffle ();

			Current = this;
		}
	}
}