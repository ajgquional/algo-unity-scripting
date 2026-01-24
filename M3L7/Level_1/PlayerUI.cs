/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Description: 
 *      Connects the UI to the health and coin modules,
 *      incorporating best practices in modular 
 *      development (recall that coin collection and 
 *      health mechanics have already been removed from 
 *      the Player).
 * 
 * How to use:
 *      - Replace the previous PlayerUI script with this one
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
    public CoinsCounter coinsCount;             // link to the number of coins declared in CoinsCounter class
    public Health health;                       // link to the health declared in the Health class
    
    public TextMeshProUGUI coinsCounterText;    // link to the TextMeshProGUI component of the coin counter
    public Slider healthSlider;                 // link to the Slider component of the health scale

    // frame-by-frame update of UI elements
    void Update()
    {
        // updating the player's health value
        healthSlider.maxValue = health.maxHealth;
        healthSlider.value = health.health;

        // updating the text with the number of coins
        // ToString() method converts a numeric data type to string
        coinsCounterText.text = coinsCount.coins.ToString();
    }
}
