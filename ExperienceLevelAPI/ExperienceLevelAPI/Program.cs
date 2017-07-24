using System;

/* Example for use of ExperienceLevelAPI
 * 
 */

namespace ExperienceLevelAPI
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ExperienceLevelConverter converter = new ExponentialLevelConverter ();
			ExperienceLevelAPI expLvlManager = new ExperienceLevelAPI (converter);

			printExpInfo (expLvlManager);

			expLvlManager.changeExperience (10);
			printExpInfo (expLvlManager);

			expLvlManager.changeExperience (5);
			printExpInfo (expLvlManager);


			expLvlManager.changeExperience (5);
			printExpInfo (expLvlManager);


			expLvlManager.changeExperience (3);

			Console.WriteLine (expLvlManager.ToString());
			Console.WriteLine ("exp for lvl 7: "+expLvlManager.getExperienceForLevel (7));
			Console.WriteLine ("exp to lvl 7: "+expLvlManager.getExperienceToLevel(7));

			Console.WriteLine (expLvlManager.ToString());
			Console.WriteLine ("exp for lvl 3: "+expLvlManager.getExperienceForLevel (3));
			Console.WriteLine ("exp to lvl 3: "+expLvlManager.getExperienceToLevel(3));

			printExpInfo (expLvlManager);

			expLvlManager.resetToLastLevelup ();
			printExpInfo (expLvlManager);

			expLvlManager.changeExperience (-17);
			printExpInfo (expLvlManager);

			expLvlManager.Level = 5;
			printExpInfo (expLvlManager);

			Random rng = new Random ();
			for (int i = 0; i < 25; i++) {
				Console.WriteLine ();
				long expChange = rng.Next (-250000, 250000);
				Console.WriteLine ("change exp: " + expChange);
				expLvlManager.changeExperience (expChange);
				printExpInfo (expLvlManager);
			}
		}

		private static void printExpInfo(ExperienceLevelAPI expLvlManager){
			Console.WriteLine ("---------------------------------------------------------------------------");
			Console.WriteLine (expLvlManager.ToString());
			Console.WriteLine ("exp to level-Up: "+expLvlManager.getExperinceToNextLevel());
			Console.WriteLine ("percent exp progress to next level-up: "+expLvlManager.getPercentExpToNextLevel());
			Console.WriteLine ("---------------------------------------------------------------------------");
		}
	}
}
