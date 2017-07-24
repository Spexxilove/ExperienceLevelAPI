using System;

namespace ExperienceLevelAPI
{
	/// <summary>
	/// Experience level converter base class
	/// the conversion function has to be a bijection and strictly monotonically increasing
	/// start values have to be:
	/// 	exp = 0
	/// 	lvl = 1
	/// </summary>
	public abstract class ExperienceLevelConverter
	{
		public abstract long experineceToLevel(long exp);
		public abstract long levelToExperience(long lvl);
	}
}

