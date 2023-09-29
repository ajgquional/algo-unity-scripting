/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program implements a temperature for the Player
 *      which will gradually decrease. Player's health would
 *      decrease if the temperature goes below a certain
 *      temperature threshold.
 * 
 * How to use the script:
 *      - Attach the script to the Player in Level 2
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    public Health health;                       // link to the health of the Player
    public int playerDamage = 2;                // amount of damage that the Player will receive
    public float temperatureCurrent = 36.6f;    // default starting temp of the Player
    public float temperatureNormal = 36.6f;     // normal temp of the Player, for bonfire operation
    public float temperatureCritical = 34f;     // temp threshold of the Player
    public float freezeSpeed = 0.05f;           // small reduction to the temp of the Player
    public float freezeDamageTimer = 1;         // timer to facilitate delay in the damage to the Player
    public float freezeDamageDelay = 2;         // amount of delay to the damage done to the Player

    // continuously reduce the Player's temperature
    // also, continuously check if the temperature goes below a critical temp
    void Update()
    {
        // gradually reduce the Player's temperature per frame
        temperatureCurrent -= freezeSpeed * Time.deltaTime;

        // continuously check if the current temp of the Player is below the critical temp
        if (temperatureCurrent <= temperatureCritical)
        {
            // after the delay is done, Player takes damage
            if (freezeDamageTimer <= 0)
            {
                health.TakeDamage(playerDamage);        // Player takes damage
                freezeDamageTimer += freezeDamageDelay; // resets the damage timer by the amount of delay
            }

            else
            {
                freezeDamageTimer -= Time.deltaTime;    // delays the damage done to the Player
            }
        }
    }
}
