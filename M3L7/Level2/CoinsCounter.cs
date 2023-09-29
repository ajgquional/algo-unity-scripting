/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program solely contains the coin collection
 *      mechanic (which is removed from the Player, following
 *      practices in modular development).
 * 
 * How to use the script:
 *      - Attach the script to the Player (after doing so,
 *          make sure that the Player script is removed)
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
