# Quick description about the scripts

* <b>Player.cs</b> - same script as before but now updated with a changed access modifier for health and coins fields from private to public, since another script (PlayerUI.cs) needs to access those fields
* <b>PlayerUI.cs</b> - updates the UI elements (health slider, timer countdown, and coins counter) frame-by-frame; thus, the script links to the various UI elements added to the game screen
* <b>Timer.cs</b> - same script as before but now updated to have a link to the timer UI object as well as a conversion of seconds to integer and finally to a string before printing the time on the player's screen
