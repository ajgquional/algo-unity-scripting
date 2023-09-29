/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program solely contains the fireball attack
 *      mechanic (which is removed from the Player, following
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

public class FireballAttack : MonoBehaviour
{
    public GameObject fireballPrefab;   // storing the prefab of the fireball
    public Transform attackPoint;       // location of the departure point of the fireball

    // method to implement the firing of the fireballs
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
