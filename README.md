# Sample Unity 3D Platformer

## About the game

This is a sample 3D platformer game mainly used to teach C# scripting in Unity. Starting from Lesson 3 of Module 1 and up to Lesson 4 of Module 4 of the Unity Game Development course, students would progressively and gradually work on the development of the game. Specifically, students would implement various game mechanics leading to the completion of the 3D game. 

The game follows a main character (a wizard). Initially, the Player is in first-person but as animation is discussed (in Module 4), the player character is changed so that the game is played in third-person. The wizard player can navigate around the world using the usual navigational keys (WASD and Space Bar to jump). There are various objects that can be interacted with, such as an accelerator to make the wizard run fast, a trampoline and a lift to allow the wizard move to a higher point in the level, spikes as traps, and coins to collect. Additionally, there is an added combat to the game in that a turtle enemy can be destroyed by firing a fireball from the wizard's staff.

There are also levels in the game. Level 1 shows the wizard player navigating in a mountain environment. At the end of Level 1, there is a gate that the player can "go through" to progress to Level 2 which is an "icy world." Once the player arrived at Level 2, the game switches to first-person and the objective of the player is to collect coins while surviving in the cold. In this regard, a temperature gauge is placed on the User Interface to inform the player that when the temperature of the player goes below a critical temperature, damage would be inflicted. To mitigate the effects of winter, bonfires are placed in the level where the player can "warm up" to stop the damage to the player.

In Module 4, animations are discussed and these are incorporated in the game. Starting from adding a simple animation for a button and a gate (by which when the button is touched, an animation would be played signifying that it's pressed and the blue gate would open), the activities would progress to the creation of a character animation up to adding a cutscene. By doing these last activities, the game is complete.

In short, the player plays as a wizard, navigate through the mountain level (Level 1) while killing enemies and collecting coins, before transferring to Level 2 which transitions the game to a first-person survival game. Note that this is only a sample game for educational purposes, but further expansions and developments can be implemented (and these are currently being thought of).

## About the repository

This repository mainly contains C# scripts used in each lesson; thus, the actual assets and scenes are not included. However, there are relevant links placed here to access the Unity project at various completion stages. To aid in navigating this repository, scripts are placed in the corresponding lesson folder, in which the name is shorthanded as "MXLY" where X is the module number and Y is the lesson number (for example, Module 1 Lesson 1, following the folder notation, is M1L1). The folder notations in this repository are specified below, along with the lesson title as well as a listing of the scripts contained in the folder (for easy navigation): 

* M3L1: Introduction to the C# language
  * CreatePrimitive.cs
  * Crickets.cs
  * Destroy.cs
  * HelloWorld.cs
    
* M3L2: Variables and data types
  * NPC.cs
    
* M3L3: Object classes
  * SceneChange.cs
  * SpeedTrigger.cs
  * Teleport.cs
  * Trampoline.cs
    
* M3L4: Functions and methods
  * Coin.cs (version 1)
  * Enemy.cs (version 1)
  * Missile.cs
  * Player.cs
    
* M3L5: Conditional constructs
  * Enemy.cs (version 2)
  * Platform.cs
  * Player.cs (version 2)
  * Timer.cs (version 1)
    
* M3L6: Player Interface
  * Player.cs (version 3)
  * PlayerUI.cs (version 1)
  * Timer.cs (version 2)
    
* M3L7: Modular development
  * Level_1 Scripts
    * Coin.cs (version 2)
    * CoinsCounter.cs
    * Enemy.cs (version 3)
    * FireballAttack.cs
    * Health.cs
    * PlayerUI.cs (version 2)
      
  * Level_2 Scripts
    * Bonfire.cs
    * Temperature.cs
    * TemperatureUI.cs
      
  * Menu Scripts
    * ExitButton.cs
    * StartButton.cs
      
* M4L1: Introduction to animation
  * Button.cs

Aside from the scripts, each folder also contains individual README files which contains a short description about the script, as well as relevant links and files to aid in the completion of a certain activity. Mainly, the README files contain guides on how to use the scripts and complete an activity.

Note that this repository would be continuously updated to include relevant informational materials, so be sure to check this repository from time-to-time.

## Relevant general resources
* Unity User Manual 2021.3 (LTS): https://docs.unity3d.com/2021.3/Documentation/Manual/UnityManual.html
* Best Practices for Organizing your Unity Project: https://unity.com/how-to/organizing-your-project
