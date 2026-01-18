/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Description: 
 *      Implements basic Player mechanics, as well as 
 *      improved health and coins management.
 * 
 * How to use:
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
    public GameObject fireballPrefab;   // storing the prefab of the fireball
    public Transform attackPoint;       // location of the departure point of the fireball

    // to implement sound effect when damage is received
    public AudioSource audioSource;     // object responsible for audio playback
    public AudioClip damageSound;       // sound file containing the sound of damage

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
            print("Player's health: " + health);    // prints the player's health in the console (for debugging purposes)
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
