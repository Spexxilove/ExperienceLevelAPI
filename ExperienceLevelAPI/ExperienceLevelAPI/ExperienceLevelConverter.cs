using System;

namespace ExperienceLevelAPI
{
	public abstract class ExperienceLevelConverter
	{
		public abstract long experineceToLevel(long exp);
		public abstract long levelToExperience(long lvl);
	}
}

