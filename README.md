# Notes about the scripts

#### M3L1: Introduction to the C# language

* <b>HelloWorld.cs</b> - prints the text "Hello, World!" in the Unity Editor console once at the beginning of the game
* <b>Crickets.cs</b> - prints the text "crickets" in the Unity Editor console every frame
* <b>Destroy.cs</b> - destroys the primitive that the script is attached to at the beginning of the game
* <b>CreatePrimitive.cs</b> - creates a figure resembling Steve from Minecraft at the beginning of the game

#### M3L2: Variables and data types

* <b>NPC.cs</b> - prints the NPC's health in the console once at the beginning of the game and moves the NPC across the plane along the z-axis

#### M3L3: Object classes

* <b>SpeedTrigger.cs</b> - accelerates the player once an accelerator object is touched
* <b>Trampoline.cs</b> - increases the jumpStrength property of the player once a trampoline object is touched
* <b>SceneChange.cs</b> - teleports the player back to the spawn point (by reloading the scene) once a trap object is touched
* <b>Teleport.cs</b> - teleports the player to a set teleportPoint once a teleporter object is touched

#### M3L4: Functions and methods

* <b>Player.cs</b> - contains player properties (such as health and number of coins) and methods for taking damage, collection of coins, and preliminary controls (firing of fireballs using left mouse button)
* <b>Enemy.cs</b> - contains enemy properties (such as speed, target, and amount of damage it inflicts) and methods to control the enemy's movement and to inflict damage to the player
* <b>Coin.cs</b> - contains the code describing what would happen to the coin when the player touches it
* <b>Missile.cs</b> - contains the code describing the projectile's movement and what would happen if an enemy collides with it

#### M3L5: Conditional constructs

* <b>Player.cs</b> - same script as before but now updated to include codes to play a sound effect when the player receives some damage and to restart the level when there's no more health left
* <b>Platform.cs</b> - script to move a platform up or down (as if it's an elevator) when the player rides it; also, the script includes conditions to reverse the platform's direction when the platform touches specified stopping points in the scene
* <b>Timer.cs</b> - adds a countdown timer to the game; when the time reaches zero, the level restarts
* <b>Enemy.cs</b> - same script as before but now updated to catch NullReferenceException error; specifically, a condition is added in the script to check if it's really the player who touches the enemy

#### M3L6: Player Interface

* <b>Player.cs</b> - same script as before but now updated with a changed access modifier for health and coins fields from private to public, since another script (PlayerUI.cs) needs to access those fields
* <b>PlayerUI.cs</b> - updates the UI elements (health slider, timer countdown, and coins counter) frame-by-frame; thus, the script links to the various UI elements added to the game screen
* <b>Timer.cs</b> - same script as before but now updated to have a link to the timer UI object as well as a conversion of seconds to integer and finally to a string before printing the time on the player's screen
