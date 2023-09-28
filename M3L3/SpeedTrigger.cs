/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program implements increased run speed to the
 *      Player when an Accelerator object is touched.
 * 
 * How to use the script:
 *      - Add a Box Collider to the Accelerator
 *      - Attach the script to the Accelerator
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    // creating a public speedFactor field with a default value of 2.5
    public float speedFactor = 2.5f;

    // method to be executed when the Player enters the accelerator
    void OnTriggerEnter(Collider other)
    {
        // increasing the player's running speed
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
        
        /* Notes:
         * other - game object touching the accelerator (which is the Player)
         * GetComponent - method to get the desired component of the game object (Player) touching the accelerator
         * FirstPersonMovement - component of the Player where the runSpeed property is in
         * runSpeed - property of the FirstPersonMovement component which is the one being changed
         */
    }

    // method to be executed when the Player exits the accelerator
    void OnTriggerExit(Collider other)
    {
        // reducing the player's running speed
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}
