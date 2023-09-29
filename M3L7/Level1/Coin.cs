/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program implements an improved coin collection 
 *      mechanic incorporating modular development
 *      practices (i.e. by using a CoinsCounter class;
 *      that is, the coins have already been removed from 
 *      the Player).
 * 
 * How to use the script:
 *      - Replace the previous Coin script with this one
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // when the Player collides with the coin,
    // the coin will be collected by calling the CollectCoins method of the CoinsCounter and
    // the coin will be destroyed by using the Destroy function
    void OnTriggerEnter(Collider other)
    {
        // creating a coins object belonging to the CoinsCounter class
        CoinsCounter coins = other.GetComponent<CoinsCounter>();

        // the number of coins is incremented by calling the CollectCoins method of the CoinsCounter class
        coins.CollectCoins();

        // the coin that was collected is destroyed
        Destroy(gameObject);
    }
}
