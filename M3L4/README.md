# Module 3, Lesson 4: Functions and methods

This part of the repository contains the scripts for Module 3, Lesson 4: Functions and methods. The lesson is about the use of methods (and how it's compared with functions). The activities in the lesson deal with the implementation of combat mechanics and a coin collection mechanic. In line with the lesson, the mechanics are mainly implemented using methods. Particularly, the Player script contains the properties of the player such as the health. The health of the Player would be reduced when an Enemy is touched. The Player can also destroy the enemy by making use of a fireballs that can be launched from a staff. Lastly, the coin collection mechanic is implemented by methods (in the Player script and Coin script).  

# Guides:

## Quick description about the scripts

* <b>Player.cs</b> - contains player properties (such as health and number of coins) and methods for taking damage, collection of coins, and preliminary controls (firing of fireballs using the left mouse button)
* <b>Enemy.cs</b> - contains enemy properties (such as speed, target, and amount of damage it inflicts) and methods to control the enemy's movement and to inflict damage to the player
* <b>Coin.cs</b> - contains the code describing what would happen to the coin when the player touches it
* <b>Missile.cs</b> - contains the code describing the projectile's movement and what would happen if an enemy collides with it

## General instructions on using the scripts

The scripts in the lesson serve different purposes, as outlined above. To be able to use them, make sure to find or add the appropriate game objects in the 3D Platformer game template. Make sure as well that there are Collider components for the Player to be able to interact with them. The Coin and Player objects are already in the template, but the Enemy and wizard staff (and the fireball prefab) aren't. Make sure to setup these objects first. Once the objects are setup, the scripts can now be attached to the appropriate game objects. Once the script is attached, check the script components if object instances need to be assigned to a corresponding field (such as in the Enemy and Missile scripts).  

For specific details on using the scripts, a step-by-step guide is provided below.

## Relevant links

* Direct activities guide in Google Slides: https://docs.google.com/presentation/d/1UhWyxyq9SOLV_elCmKw3eITyRBJSx7Eja1O9D-E2F5Q/edit?usp=sharing
* Complete handbook/lesson slides (c/o Algorithmics): https://docs.google.com/presentation/d/1xhmeGoa7KnyGdCaa-AT2zADagDa9Jzt8zURlojlJarM/edit?usp=sharing
* Completed activity (c/o Algorithmics): https://drive.google.com/file/d/1Zhz-Nso02gfTQ1zjLlagx2OzvVeksN1t/view
