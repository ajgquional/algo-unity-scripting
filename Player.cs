using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // health of the player
    // private access modifier since the health value is not intended to be accessible to other scripts
    private int health = 10;

    // note: this is additional, to implement collection of coins
    private int coins;  // number of coins collected

    // note: this is additional, to implement firing of fireballs
    public GameObject fireballPrefab;   // storing the prefab of the fireball
    public Transform attackPoint;       // location of the departure point of the fireball

    // method to reduce the player's health by the amount of damage done
    public void TakeDamage(int damage)
    {
        health -= damage;                       // health = health - damage; player's health is reduced according to the amount of damage
        print("Player's health: " + health);    // prints the player's health in the console
    }

    // additional code, to implement collection of coins
    public void CollectCoins()
    {
        coins++;                                // increments the number of coins of the player
        print("Collected coins: " + coins);     // prints the number of coins in the console
    }

    // additional code, to implement firing of fireballs
    void Update()
    {
        // if left mouse button is pressed, create the fireballs
        if (Input.GetMouseButtonDown(0))
        {
            // code to create the fireballs
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
