/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program implements a combat mechanic:
 *      Enemy continuously moves toward a target
 *      and the target receives a damage when the 
 *      Enemy is touched
 * 
 * How to use the script:
 *      - Setup the enemy first and add a Collider
 *      - Attach the script to all the Enemy objects
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // enemy properties:
    public float speed;             // enemy speed
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
        // getting the Player component of the designated player in the game
        Player player = other.GetComponent<Player>();

        // Player takes damage by calling the TakeDamage method of the Player
        player.TakeDamage(playerDamage);
    }
}
