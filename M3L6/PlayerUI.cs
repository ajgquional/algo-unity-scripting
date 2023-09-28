/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program implements the operation of the 
 *      designed UI. Specifically, this updates the 
 *      health, time, and number of coins.
 * 
 * How to use the script:
 *      - Attach the script to the Player
 *      - Link the Coins Counter Text and Health Slider objects
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   // library needed to work with the interface
using TMPro;            // library needed to work with text

public class PlayerUI : MonoBehaviour
{
    // links to other game objects, assignable via the Inspector window
    public Player player;                       // link to the Player component of the player
    public TextMeshProUGUI coinsCounterText;    // link to the TextMeshProGUI component of the coin counter
    public Slider healthSlider;                 // link to the Slider component of the health scale

    // frame-by-frame update of UI elements
    void Update()
    {
        // updating the player's health value
        healthSlider.maxValue = player.maxHealth;
        healthSlider.value = player.health;

        // updating the text with the number of coins
        // ToString() method converts a numeric data type to string
        coinsCounterText.text = player.coins.ToString();
    }
}
