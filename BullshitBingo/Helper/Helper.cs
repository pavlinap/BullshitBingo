﻿using System;
using System.Collections.Generic;

namespace BullshitBingo
{
	public static class Helper
	{
		public static void Shuffle<T>(this IList<T> list)
		{  
			var random = new Random();
			var n = list.Count;

			while (n > 1)
			{
				n--;
				var k = random.Next(n + 1);
				T value = list[k];  
				list[k] = list[n];
				list[n] = value;  
			}
		}
	}
}

