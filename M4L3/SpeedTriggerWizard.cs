/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program is similar to the previous SpeedTrigger
 *      script which increases the run speed of the Player
 *      when an Accelerator object is touched, except that
 *      this time, the script gets the ThirdPersonMovement
 *      component of the Player rather than the 
 *      FirstPersonMovement component.
 * 
 * How to use the script:
 *      - Attach the script to the Accelerator object
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTriggerWizard : MonoBehaviour
{
    // creating a public speedFactor field with a default value of 2.5
    public float speedFactor = 2.5f;

    // method to be executed when the Wizard enters the accelerator
    void OnTriggerEnter(Collider other)
    {
        // increasing the Wizard's running speed
        other.GetComponent<ThirdPersonMovement>().runSpeed *= speedFactor;
    }

    // method to be executed when the Wizard exits the accelerator
    void OnTriggerExit(Collider other)
    {
        // reducing the player's running speed
        other.GetComponent<ThirdPersonMovement>().runSpeed /= speedFactor;
    }
}
