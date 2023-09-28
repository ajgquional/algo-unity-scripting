/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program implements teleportation between
 *      two points when a Teleporter is touched.
 * 
 * How to use the script:
 *      - Setup two teleport points inside the Teleports
 *      - Attach the script to the Teleport objects
 *      - Specify that the teleportPoint of the 1st
 *          Teleport object is the teleportPoint of
 *          the 2nd Teleport object
 *      - Specify that the teleportPoint of the 2nd
 *          Teleport object is the teleportPoint of 
 *          the 1st Teleport object 
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // empty public field storing the data about the point to which the Player needs to teleport
    public Transform teleportPoint;

    // method to be executed when the Player enters the teleporter
    void OnTriggerEnter(Collider other)
    {
        // changes the player's position to the position of the teleportPoint specified in the public field
        other.transform.position = teleportPoint.position;
    }
}
