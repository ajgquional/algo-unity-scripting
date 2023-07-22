using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    // fireball flight speed
    public float speed = 5;

    // continuously move the fireball once it's created
    // then, always destroy the fireball after 3 seconds, regardless if the fireball collided with the enemy or not
    void Update()
    {
        // the fireball clone is destroyed after 3 seconds
        Destroy(gameObject, 3);

        // in each frame the ball position is updated by the product of the forward motion vector (0,0,1),
        // the speed of the ball and the value of the difference in seconds between the last and current frames
        transform.position +=  transform.forward * speed * Time.deltaTime;
    }

    // when the enemy collides with the fireball, both will be destroyed 
    private void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();  // getting the Enemy component of the designated enemy in the game
        Destroy(enemy.gameObject);                  // destroys the enemy

        Destroy(gameObject);                        // destroys the fireball as well
    }
}
