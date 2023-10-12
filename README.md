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
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L1/CreatePrimitive.cs">CreatePrimitive.cs</a>
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L1/Crickets.cs">Crickets.cs</a>
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L1/Destroy.cs">Destroy.cs</a>
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L1/HelloWorld.cs">HelloWorld.cs</a>
    
* M3L2: Variables and data types
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L2/NPC.cs">NPC.cs</a>
    
* M3L3: Object classes
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L3/SceneChange.cs">SceneChange.cs</a>
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L3/SpeedTrigger.cs">SpeedTrigger.cs</a>
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L3/Teleport.cs">Teleport.cs</a>
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L3/Trampoline.cs">Trampoline.cs</a>
    
* M3L4: Functions and methods
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L4/Coin.cs">Coin.cs (version 1)</a>
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L4/Enemy.cs">Enemy.cs (version 1)</a>
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L4/Missile.cs">Missile.cs</a>
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L4/Player.cs">Player.cs (version 1)</a>
    
* M3L5: Conditional constructs
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L5/Enemy.cs">Enemy.cs (version 2)</a>
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L5/Platform.cs">Platform.cs</a>
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L5/Player.cs">Player.cs (version 2)</a>
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L5/Timer.cs">Timer.cs (version 1)</a>
    
* M3L6: Player Interface
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L6/Player.cs">Player.cs (version 3)</a>
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L6/PlayerUI.cs">PlayerUI.cs (version 1)</a>
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L6/Timer.cs">Timer.cs (version 2)</a>
    
* M3L7: Modular development
  * Level_1 Scripts
    * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L7/Level_1/Coin.cs">Coin.cs (version 2)</a>
    * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L7/Level_1/CoinsCounter.cs">CoinsCounter.cs</a>
    * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L7/Level_1/Enemy.cs">Enemy.cs (version 3)</a>
    * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L7/Level_1/FireballAttack.cs">FireballAttack.cs</a>
    * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L7/Level_1/Health.cs">Health.cs</a>
    * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L7/Level_1/PlayerUI.cs">PlayerUI.cs (version 2)</a>
      
  * Level_2 Scripts
    * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L7/Level_2/Bonfire.cs">Bonfire.cs</a>
    * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L7/Level_2/Temperature.cs">Temperature.cs</a>
    * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L7/Level_2/TemperatureUI.cs">TemperatureUI.cs</a>
      
  * Menu Scripts
    * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L7/Menu/ExitButton.cs">ExitButton.cs</a>
    * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M3L7/Menu/StartButton.cs">StartButton.cs</a>
      
* M4L1: Introduction to animation
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M4L1/Button.cs">Button.cs (version 1)</a>

* M4L2: Character animation. Part 1
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M4L2/CharacterAnim.cs">CharacterAnim.cs (version 1)</a>

* M4L3: Character animation. Part 2
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M4L3/Button.cs">Button.cs (version 2)</a>
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M4L3/CharacterAnim.cs">CharacterAnim.cs (version 2)</a>
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M4L3/SpeedTriggerWizard.cs">SpeedTriggerWizard.cs</a>
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M4L3/ThirdPersonMovement.cs">ThirdPersonMovement.cs</a>
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M4L3/TrampolineWizard.cs">TrampolineWizard.cs</a>
  * <a href="https://github.com/ajgquional/algo-unity-scripting/blob/main/M4L3/WizardMotion.cs">WizardMotion.cs</a>

Aside from the scripts, each folder also contains individual README files which contains a short description about the script, as well as relevant links, tutorials, and files to aid in the completion of a certain activity. Mainly, the README files contain guides on how to use the scripts and complete an activity.

Lastly, this repository contains links for general resources relevant to Unity game development.

Note that this repository would be continuously updated to include relevant informational materials (such as links for general resources as well as tutorials, when they're available), so be sure to check this repository from time-to-time.

### Special note about the scripts:
* Some scripts have different versions according to the lesson being discussed. This versions are due to improvements to the previous versions, incorporating the topic at hand. In particular, to reduce confusion, take note that the following scripts have multiple versions:
  * Coin.cs
  * Enemy.cs
  * Player.cs
  * Timer.cs
  * PlayerUI.cs
  * Button.cs
  * CharacterAnim.cs
 * The program contained in the scripts is highly annotated. Although this may not be the best practice from a software development perspective (that is, the high amount of annotations), the annotations serve as a detailed explanation and guide for the student. Refer to the comments in the program to see what a particular line of code is meant to do.

## Relevant general resources
* Unity User Manual 2021.3 (LTS): https://docs.unity3d.com/2021.3/Documentation/Manual/UnityManual.html
* Best practices for organizing Unity projects: https://unity.com/how-to/organizing-your-project
* Guide to installing Unity and Visual Studio: https://docs.google.com/presentation/d/1L1hf9a-YMDx0rZ7VZBhkanCopPNAAJmHwct25tpCXpA/edit?usp=sharing
* Guide to opening a finished project in Unity: https://docs.google.com/presentation/d/1gXI5NOyFDUqjzFj8BQFozMKhZod47HU-8PnADnL-1ok/edit?usp=sharing
* Guide to importing free Unity assets: https://docs.google.com/presentation/d/14vaSBWyN4ChXCyHN2nHMvsAde0XoAlurkDgopN4nDA0/edit?usp=sharing
