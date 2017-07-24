# ExperienceLevelAPI

This is an API intended for use in RPG games to manage Experience and level of characters.  
The conversion formula for experience -> level has to be provided by the developer as an implenmentation of ExperienceLevelConverter.  
Examples are provided in LinearLevelConverter and ExponentialLevelConverter  

#### API files:  
  - ExperinceLevelAPI.cs  
  - ExperineceLevelConverter.cs  
  
#### Example converters:  
  - LinearLevelConverter.cs  
  - ExponentialLevelConverter.cs  
  
#### Example API usage:  
  - Program.cs  


### Initial Requirements:  
Experience Level API  
We are creating a typical turn-based RPG with a team of characters, think Final Fantasy. We need you to create a small software module    that takes care of managing experience points and level.  

#### General Requirements:  
must be able to offer independent experience level management for each character  
Pure C#/.Net: the module will later be integrated into a Unity project, but it should be independent of UnityEngine. This means it still needs to compile within Unity (currently: 5.5).  
the manager revolves around 2 central values, "experience" (long) and "level" (long), where both can be represented interchangeably (e.g.: 110 Experience = Level 1 (+10 Experience), Level 1 = 100 Experience)  

#### API Requirements:  
- API consumer (game designer) should be able to inject any experience-level conversion formula(s) into the module  
- get current level  
- get experience value for an arbitrary level value  
- get level value for an arbitrary experience value  
- get experience needed until next level-up  
- get percentual experience progress between last and next level-up  
- get experience delta between current experience and an arbitrary level value  
- add / subtract experience  
- set level  
- reset experience to last level-up  
