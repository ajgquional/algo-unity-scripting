# Module 3, Lesson 5: Conditional constructs

This part of the repository contains the scripts for Module 3, Lesson 5: Conditional constructs. The lesson is about the use of conditional constructs (if, if/else) in scripts. The activities in the lesson deal with improvements in the previously created scripts (Player and Enemy) as well as implementation of new mechanics to the game, such as the inclusion of an elevator/lift and a timer.  

# Guides:

## Quick description about the scripts

* <b>Player.cs</b> - same script as before but now updated to include codes to play a sound effect when the player receives some damage and to restart the level when there's no more health left
* <b>Platform.cs</b> - script to move a platform up or down (as if it's an elevator) when the player rides it; also, the script includes conditions to reverse the platform's direction when the platform touches specified stopping points in the scene
* <b>Timer.cs</b> - adds a countdown timer to the game; when the time reaches zero, the level restarts
* <b>Enemy.cs</b> - same script as before but now updated to catch NullReferenceException error; specifically, a condition is added in the script to check if it's really the player who touches the enemy

## General instructions on using the scripts

The scripts in the lesson serve different purposes, as outlined above. To be able to use them, make sure to setup the needed game objects, as in the case of the platform (elevator/lift). As for the other game objects, such as the Player and Enemy, they are already present in the game so no additional setup is needed (aside from adding a tag to the Player as a "Player" as this is needed by both the Platform and Enemy scripts. Then, as usual, attach the scripts to the appropriate game objects.

For specific details on using the scripts, a step-by-step guide is provided below.

## Relevant links

* Direct activities guide in Google Slides: https://docs.google.com/presentation/d/1_pkL_4Y8ILZfPzHA3JsFQBsDzjfb50JtzEPUoUc316g/edit?usp=sharing
* Complete handbook/lesson slides (c/o Algorithmics): https://docs.google.com/presentation/d/1xUMXYVWzK9v9bW4sriWJHLREfwKzgPi07ZlZA18h0HU/edit?usp=sharing
* Completed activity (c/o Algorithmics): https://drive.google.com/file/d/1c9hyWjGROwcfh1wmcTXVzNYQ7Z7PqExF/view
