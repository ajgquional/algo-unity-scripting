# Module 3, Lesson 7: Modular development

This part of the repository contains the scripts for Module 3, Lesson 7: Modular development. The lesson is about the application of modular development practices to the 3D Platformer game being developed. This practice would facilitate the reduction of bugs as the game gets bigger and more complex. Being so, the main activity in the lesson is to modularize the Player script into three separate scripts: Health.cs, CoinsCounter.cs, and FireballAttack.cs. In this way, each game mechanic is separated which can reduce chances of bugs appearing in different scripts, should another level has been decided to be added to the first level.

Speaking of levels, the addition of Level 2 is the next activity after modularizing the Player script. Level 2 has a different mechanic: the world is icy, the Player is back to first-person view and has to survice the cold, and the timer has already been deleted. Scripts for Level 2 are needed for the inclusion of the Player's temperature, operation of the bonfires, and an update on the Player's temperature via a UI.

As a bonus, a main menu interface is suggested to be created. The main menu has a "Start" and "Exit" button: the "Start" button allows a transfer to Level 1 while the "Exit" button exits the game. Each button would definitely use a script. 

# Guides:

## Quick description about the scripts in each folder

* <b>Level_1</b> - contains new and updated scripts used in Level 1 of the game
  * <b>Coin.cs</b> - same as before but now updated to include a reference to the CoinsCounter script (the coin collection mechanic separated from the Player script)
  * <b>CoinsCounter.cs</b> - the coin collection mechanic that is separated from the Player script
  * <b>Enemy.cs</b> - same as before but now updated to include a reference to the Health script (the health mechanic separated from the Player script)
  * <b>FireballAttack.cs</b> - the Player's attack mechanic that is separated from the Player script
  * <b>Health.cs</b> - the Player's health mechanic that is separated from the Player script
  * <b>PlayerUI.cs</b> - same as before but now updated to include a reference to the CoinsCounter and Health scripts

* <b>Level_2</b> - contains scripts used in Level 2 of the game
  * <b>Bonfire.cs</b> - implements the operation of the bonfires in the game: the lifetime would continuously decrease and when the Player goes near it, the temperature of the Player increases
  * <b>Temperature.cs</b> - adds a temperature to the Player and the corresponding mechanic: temperature continuously decreases and when the temperature goes below a certain critical temperature, the Player's health would be reduced (unless the Player goes near a bonfire to increase the Player's temperature)
  * <b>TemperatureUI.cs</b> - implements an update to the Player's temperature in the UI

* <b>Menu</b> - contains scripts for the operation of the Start and Exit buttons in the main menu
  * <b>ExitButton.cs</b> - doesn't proceed with Level 1 if the Exit button is clicked
  * <b>StartButton.cs</b> - makes the player proceed to Level 1 if the Start button is clicked

## General instructions on using the scripts

The scripts in the lesson serve different purposes, as outlined above. Some scripts are updated versions (Coin.cs, Enemy.cs, and PlayerUI.cs) to incorporate a reference to the scripts separated from the previous Player script (which is not needed anymore). Some scripts are entirely new, incorporating modular development practices, to implement new mechanics. The use of the Level 1 scripts doesn't need a prerequisite or prior setup in the game. 

Level 2 scripts need some prior setup. Bonfires need to have a Collider first to enable player collision; thus, this is needed to be done before trying to implement Bonfire.cs. A temperature UI needs to be designed first before trying to implement Temperature.cs and TemperatureUI.cs. (Additionally, the timer must be removed from the UI.)

Menu scripts definitely need a prior setup before the scripts can be used. The main menu UI with Start and Exit buttons must be created first. After that, the button scripts can be added to the corresponding buttons.

For specific details on using the scripts, a step-by-step guide is provided below.

## Relevant links

* Direct activities guide in Google Slides: 
* Complete handbook/lesson slides (c/o Algorithmics): https://docs.google.com/presentation/d/1xIri7cODZmV9Vg6jjsh6JKOEbFPL8Wxh4dqIhTG_lTA/edit?usp=sharing
* Completed activity (c/o Algorithmics): https://drive.google.com/file/d/1Py2bPiWxPTkJ-2V7bZofO8yfxBdx68cE/view
