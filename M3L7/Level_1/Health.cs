/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program solely contains the health mechanic
 *      (which is removed from the Player, following
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
using UnityEngine.SceneManagement; // library to be able to work with the game scene

public class Health : MonoBehaviour
{
    // re: health
    public int health = 10;         // current player health
    public int maxHealth = 10;      // maximum player health

    // re: audio
    public AudioSource audioSource; // object responsible for audio playback
    public AudioClip damageSound;   // sound file containing the sound of damage

    // method to reduce the Player's health by the amount of damage done
    public void TakeDamage(int damage)
    {
        // Player's health is reduced according to the amount of damage
        health -= damage;                           

        // checks if the Player has health left
        // if there's still health, play a damage sound
        if (health > 0)
        {
            audioSource.PlayOneShot(damageSound);   // plays the sound of taking damage
            print("Player's health: " + health);    // prints the Player's health in the console
        }

        // otherwise, restart the level
        else
        {
            // getting the index of the current scene and restarting it
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
