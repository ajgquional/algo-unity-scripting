/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program improves the previous Enemy program
 *      implementing modular development practices (now,
 *      a link has been setup to the Health script, not
 *      the Player script).
 * 
 * How to use the script:
 *      - Replace the previous Enemy script with this one
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // public field specifying enemy properties:
    public float speed = 2;         // enemy speed
    public Transform target;        // target that the enemy should move toward
    public int playerDamage = 2;    // damage to be inflicted by the enemy

    // continuously move and rotate the enemy towards the target
    void Update()
    {
        // changes the Enemy's position to a new one, every frame
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        // turns the Enemy to face the target, every frame
        transform.LookAt(target.position);
    }

    // when the enemy collides with the Player, the Player receives damage 
    private void OnTriggerEnter(Collider other)
    {
        // condition to ensure that it is really the player who touched the enemy
        // primarily to "catch" NullReferenceException error
        if (other.tag == "Player")
        {
            // getting the Health component of the Player
            Health health = other.GetComponent<Health>();

            // player takes damage by calling the TakeDamage method of the Health object
            health.TakeDamage(playerDamage);
        }
    }
}
