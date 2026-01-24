/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Description: 
 *      Contains the coin collection mechanic (removed 
 *      from the Player, following best practices in 
 *      modular development).
 * 
 * How to use:
 *      - Attach the script to the Player
 *      - Remove the Player script
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCounter : MonoBehaviour
{
    // number of coins of the Player
    public int coins;

    // method to implement collection of coins
    public void CollectCoins()
    {
        coins++;                                // increments the number of coins of the Player
        print("Collected coins: " + coins);     // prints the number of coins in the console
    }
}
