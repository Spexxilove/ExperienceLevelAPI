using System;

namespace ExperienceLevelAPI
{
	/// <summary>
	/// Experience level API
	/// Manages experience and level values of a character
	/// using given ExperienceLevelConverter
	/// </summary>
	public class ExperienceLevelAPI
	{
		private long exp;
		private long lvl;

		private ExperienceLevelConverter expLvlConverter;

		public ExperienceLevelAPI (ExperienceLevelConverter converter)
		{
			exp = 0;
			lvl = 1;
			expLvlConverter = converter;
		}

		/// <summary>
		/// Gets or sets the experience.
		/// </summary>
		/// <value>The experience.</value>
		public long Experience
		{
			get
			{
				return this.exp;
			}
			private set
			{
				if (value < 0) {
					throw new Exception ("experience value has to be > 0");
				}
				this.exp = value;
				lvl = expLvlConverter.experineceToLevel (this.exp);
			}
		}


		/// <summary>
		/// Gets or sets the level.
		/// </summary>
		/// <value>The level.</value>
		public long Level
		{
			get
			{
				return this.lvl;
			}
			set
			{
				if (value < 1) {
					throw new Exception ("level value has to be > 1");
				}
				lvl = value;
				exp = expLvlConverter.levelToExperience (lvl);
			}
		}

		/// <summary>
		/// Gets the experience for an atbitrary level value.
		/// </summary>
		/// <returns>The experience for level.</returns>
		/// <param name="lvl">Level. has to be > 0 </param>
		public long getExperienceForLevel(long lvl){
			if (lvl < 1) {
				throw new Exception ("invalid Level value");
			}
			return expLvlConverter.levelToExperience (lvl);
		}

		/// <summary>
		/// Gets the level for an arbitrary experience value.
		/// </summary>
		/// <returns>The level for experience.</returns>
		/// <param name="exp">Experience. hasw to be >= 0 </param>
		public long getLevelForExperience(long exp){
			if (exp < 0) {
				throw new Exception ("invalid Experience value");
			}
			return expLvlConverter.experineceToLevel (exp);
		}

		/// <summary>
		/// get experience delta between current experience and an arbitrary level value.
		/// </summary>
		/// <returns>The experience to level.</returns>
		/// <param name="lvl">level. has to be >= current level </param>
		public long getExperienceToLevel(long lvl){
			if (lvl < this.lvl) {
				throw new Exception ("Invalid Level value");
			}

			return Math.Max(0,expLvlConverter.levelToExperience(lvl) - exp);
		}

		/// <summary>
		/// get experience needed until next level-up
		/// </summary>
		/// <returns>The experince to next level.</returns>
		public long getExperinceToNextLevel(){
			return getExperienceToLevel(lvl+1);
		}

		/// <summary>
		/// get percentual experience progress between last and next level-up
		/// </summary>
		/// <returns>The percent experience to next level. (0-100) </returns>
		public double getPercentExpToNextLevel(){
			long expCurrentLvl = getExperienceForLevel (lvl);
			long expToNextLvl = getExperinceToNextLevel ();
			long expSinceLastLvl = exp - expCurrentLvl;

			return ((double)expSinceLastLvl / (double)(expSinceLastLvl + expToNextLvl)) * 100.0;
		}

		/// <summary>
		/// Changes the experience value.
		/// Experience value always stays >= 0
		/// </summary>
		/// <param name="amount">Amount of experience to add / subtract</param>
		public void changeExperience(long amount){
			if (exp + amount < 0) {
				Experience = 0;
			} else {
				Experience = exp + amount;
			}
		}

		/// <summary>
		/// Resets experience value to last level-up.
		/// </summary>
		public void resetToLastLevelup(){
			Experience = expLvlConverter.levelToExperience (lvl);
		}

		public override string ToString ()
		{
			return string.Format ("[ExperienceLevelAPI: Experience={0}, Level={1}]", Experience, Level);
		}
	}
}

