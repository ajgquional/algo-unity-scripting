/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program specifies Player properties (health, 
 *      number of collected coins, fireball to be used, and
 *      origin point of the fireball) as well as behaviors 
 *      (take damage, collect coins, create fireball).
 * 
 * How to use the script:
 *      - Attach the script to the Player
 *      - Note to implement fireball attack: setup the attack 
 *          point (point where the fireballs would be generated)
 * **************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // health of the Player
    // private access modifier since the health value is not intended to be accessible by other scripts
    private int health = 10;

    // to implement collection of coins:
    private int coins;  // number of coins collected

    // to implement firing of fireballs:
    public GameObject fireballPrefab;   // storing the prefab of the fireball
    public Transform attackPoint;       // location of the departure point of the fireball
    // note: fireballPrefab and attackPoint need to be specified in the Inspector

    // method to reduce the Player's health by the amount of damage done
    public void TakeDamage(int damage)
    {
        health -= damage;                       // health = health - damage; Player's health is reduced according to the amount of damage
        print("Player's health: " + health);    // prints the Player's health in the console
    }

    // method to implement collection of coins
    public void CollectCoins()
    {
        coins++;                                // increments the number of coins of the Player
        print("Collected coins: " + coins);     // prints the number of coins in the console
    }

    // to implement firing of fireballs, continuously check if the left mouse button is pressed
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
