/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program implements increased jump strength
 *      to the Player when a Trampoline object is touched.
 * 
 * How to use the script:
 *      - Add a Box Collider to the Trampoline
 *      - Attach the script to the Trampoline
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    // method to be executed when the Player enters the trampoline
    void OnTriggerEnter(Collider other)
    {
        // changing the jumpStrength property of the Player's Jump component by 10
        other.GetComponent<Jump>().jumpStrength += 10;
        
        /* Notes:
         * other - game object touching the trampoline (which is the Player)
         * GetComponent - method to get the desired component of the game object (Player) touching the trampoline
         * Jump - component of the Player where the jumpStrength property is in
         * jumpStrength - property of the Jump component which is the one being changed
         */
    }

    // method to be executed when the Player exits the trampoline
    void OnTriggerExit(Collider other)
    {
        // resetting the jumpStrength property of the Player's Jump component to 2
        other.GetComponent<Jump>().jumpStrength = 2;
    }
}
