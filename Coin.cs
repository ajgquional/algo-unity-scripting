using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // when the player collides with the coin,
    // the coin will be collected by calling the CollectCoins method of the player and
    // the coin will be destroyed by using the Destroy function
    void OnTriggerEnter(Collider other)
    {
        // getting the Player component because the CollectCoins method from it needs to be called
        Player player = other.GetComponent<Player>();

        // the number of coins is incremented by calling the CollectCoins method of the player
        player.CollectCoins();

        // the coin that was collected is destroyed
        Destroy(gameObject);
    }
}
