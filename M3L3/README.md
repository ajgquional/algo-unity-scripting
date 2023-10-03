# Module 3, Lesson 3: Object classes

This part of the repository contains the scripts for Module 3, Lesson 3: Object classes. The lesson is about object classes, and being so, the activities in the lesson deal with creating several object classes for the 3D Platformer game. There's an Accelerator class which would make the Player run fast when the accelerator object is touched; a Trampoline class that would make the Player jump high when the trampoline object is touched; a Scene Change class that would restart the level when a trap object is touched; and a Teleport class that would allow the Player to teleport to another location set within the game.

# Guides:

## Quick description about the scripts

* <b>SpeedTrigger.cs</b> - accelerates the player once an accelerator object is touched
* <b>Trampoline.cs</b> - increases the jumpStrength property of the player once a trampoline object is touched
* <b>SceneChange.cs</b> - teleports the player back to the spawn point (by reloading the scene) once a trap object is touched
* <b>Teleport.cs</b> - teleports the player to a set teleportPoint once a teleporter object is touched

## General instructions on using the scripts

The scripts in the lesson serve different purposes, as outlined above. To be able to use them, make sure to find the appropriate game objects in the 3D Platformer game template, then add the necessary Collider components (either in prefab mdoe or within the game itself, but it's suggested to add the collider in prefab mode, for multiple game objects) so that the object can collide with the Player. Once the Collider components are set up, create a script in an appropriate location in the project, open the script in a Code Editor, and paste the needed program from the scripts in this repository. Finally, attach the script in an appropriate game object (again, it is suggested to use the prefab mode for multiple game objects).

For specific details on using the scripts, a step-by-step guide is provided below.

## Relevant links

* Direct activities guide in Google Slides: https://docs.google.com/presentation/d/1xM1St_KlHnJdKA19ekDESsB878IQI2bj4XKiTkjlnK4/edit?usp=sharing
* Complete handbook/lesson slides (c/o Algorithmics): https://docs.google.com/presentation/d/1mDabH6d133JRzczAEp-M4P3lk8ysk1lqzOr-olWq_ao/edit?usp=sharing
* Completed activity (c/o Algorithmics): https://drive.google.com/file/d/1i7YxO7gz0tmFPnd38ASeew2u9J8s5QAI/view
