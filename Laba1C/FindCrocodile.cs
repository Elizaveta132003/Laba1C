using System;

namespace Laba1C
{
	internal static class FindCrocodile
	{
		public static Crocodile Find(this Crocodile[] crocodiles, Predicate<Crocodile> predicate)
		{
			foreach (var crocodile in crocodiles)
			{
				if (predicate(crocodile))
				{
					return crocodile;
				}
			}

			return null;
		}
	}
}
