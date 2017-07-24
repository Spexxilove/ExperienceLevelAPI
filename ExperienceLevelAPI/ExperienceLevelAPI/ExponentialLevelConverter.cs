using System;

namespace ExperienceLevelAPI
{
	/// <summary>
	/// Exponential level converter.
	/// exp = lvl^10
	/// </summary>
	public class ExponentialLevelConverter : ExperienceLevelConverter
	{
		public override long experineceToLevel (long exp)
		{
			if (exp == 0)
			{
				return 1;
			}
			return (long)Math.Floor (Math.Log10(exp)+2);
		}

		public override long levelToExperience (long lvl)
		{
			if (lvl == 1)
			{
				return 0;
			}
			//else if (lvl == 2)
			//{
			//	return 1;
			//}
			return (long)Math.Floor(Math.Pow(10,(lvl-2)));
		}
	}
}

