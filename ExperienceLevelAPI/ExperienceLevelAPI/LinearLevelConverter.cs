using System;


namespace ExperienceLevelAPI
{
/// <summary>
/// Example Linear level converter.
/// 1lvl = 10exp
/// </summary>
	public class LinearLevelConverter : ExperienceLevelConverter
	{
		public LinearLevelConverter ()
		{
		}

		public override long experineceToLevel (long exp)
		{
			return (long)Math.Floor ((decimal)exp / 10) + 1;
		}

		public override long levelToExperience (long lvl)
		{
			return (lvl - 1) * 10;
		}
	}
}

