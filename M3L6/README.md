# Module 3, Lesson 6: Player Interface

This part of the repository contains the scripts for Module 3, Lesson 6: Player Interface. The lesson is about the creation of a User Interface (UI) in the 3D Platformer game to display information about the player's health, number of coins collected, as well as the remaining time to accomplish the level. Being so, the lesson is mostly about the design of the UI. The operation of the UI (implemented through a script) is a secondary activity.

# Guides:

## Quick description about the scripts

* <b>Player.cs</b> - same script as before but now updated with a changed access modifier for health and coins fields from private to public, since another script (PlayerUI.cs) needs to access those fields
* <b>PlayerUI.cs</b> - updates the UI elements (health slider, timer countdown, and coins counter) frame-by-frame; thus, the script links to the various UI elements added to the game screen
* <b>Timer.cs</b> - same script as before but now updated to have a link to the timer UI object as well as a conversion of seconds to integer and finally to a string before printing the time on the player's screen

## General instructions on using the scripts

The scripts in the lesson serve different purposes, as outlined above. Two scripts (Player.cs and Timer.cs) are improvements to the previously created scripts while the other (PlayerUI.cs) is needed for the operation of the UI. Regarding the latter, make sure that before using it, the UI is already been designed (that is, the UI elements should already be placed in their proper places with the player's screen). After designing the UI, the PlayerUI script should be added to the Player object to facilitate a frame-by-frame update of the UI elements.

For specific details on using the scripts, a step-by-step guide is provided below.

## Relevant links

* Direct activities guide in Google Slides: 
* Complete handbook/lesson slides (c/o Algorithmics): https://docs.google.com/presentation/d/1MEbe7AoWs_F3Nc71DuWMukX2sBsFsdNdbMh8b30FpJc/edit?usp=sharing
* Completed activity (c/o Algorithmics): https://drive.google.com/file/d/1buhAgg7fgUlEGrhinQv_3hLL00CP7UX9/view
