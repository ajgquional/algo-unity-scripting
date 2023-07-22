using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // enemy properties:
    public float speed;             // enemy speed
    public Transform target;        // target that the enemy should move toward
    public int playerDamage = 2;    // damage to be inflicted by the enemy

    // continuously move and rotate the enemy towards the player
    void Update()
    {
        // changes the enemy's position to a new one, every frame
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        // turns the enemy to face the target, every frame
        transform.LookAt(target.position);
    }

    // when the enemy collides with the player, the player attains damage 
    private void OnTriggerEnter(Collider other)
    {
        // getting the Player component of the designated player in the game
        Player player = other.GetComponent<Player>();

        // player takes damage by calling the TakeDamage method of the player
        player.TakeDamage(playerDamage);
    }
}
