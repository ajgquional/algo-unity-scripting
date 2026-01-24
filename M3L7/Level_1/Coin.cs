/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Description: 
 *      Implements an improved coin collection mechanic 
 *      by connecting the CoinsCounter class, 
 *      incorporating best practices in modular 
 *      development (recall that the coin collection 
 *      mechanic has already been removed from 
 *      the Player).
 * 
 * How to use:
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
