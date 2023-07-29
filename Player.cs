using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // library to be able to work with the game scene

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

    // for audio
    public AudioSource audioSource; // object responsible for audio playback
    public AudioClip damageSound;   // sound file containing the sound of damage

    // method to reduce the player's health by the amount of damage done
    public void TakeDamage(int damage)
    {
        health -= damage;                           // health = health - damage; player's health is reduced according to the amount of damage

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
