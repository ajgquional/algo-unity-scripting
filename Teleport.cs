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
