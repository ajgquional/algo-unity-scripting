/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program contains improved code for the 
 *      Player's health and coins (specifically, the 
 *      access modifier for both has been changed to
 *      public since the UI would access their data).
 * 
 * How to use the script:
 *      - Replace the previous Player script with this one
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // library to be able to work with the game scene

public class Player : MonoBehaviour
{
    // access modifier of health now changed to public
    // current player health
    public int health = 10;

    // maximum player health
    public int maxHealth = 10;

    // access modifier of coins now changed to public
    public int coins;

    // fireball attack
    public GameObject fireballPrefab;
    public Transform attackPoint;

    // sound effect
    public AudioSource audioSource;
    public AudioClip damageSound;

    // method to reduce the player's health by the amount of damage done
    public void TakeDamage(int damage)
    {
        // player's health is reduced according to the amount of damage
        health -= damage;                           

        // checks if the player has health left
        // if there's still health, play a damage sound
        if (health > 0)
        {
            audioSource.PlayOneShot(damageSound);   // plays the sound of taking damage
            print("Player's health: " + health);    // prints the player's health in the console
        }

        // otherwise, restart the level
        else
        {
            // getting the index of the current scene and restarting it
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }

    // method to implement collection of coins
    public void CollectCoins()
    {
        coins++;                                // increments the number of coins of the player
        print("Collected coins: " + coins);     // prints the number of coins in the console
    }

    // method to implement firing of fireballs
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
