/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program is similar to the Trampoline script
 *      before which increases the jump strength of the 
 *      Player when a Trampoline object is touched, except
 *      that this time, the script has been updated 
 *      considering the Wizard's new default jump strength.
 * 
 * How to use the script:
 *      - Attach the script to the Trampoline object
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineWizard : MonoBehaviour
{
    // method to be executed when the Player enters the trampoline
    void OnTriggerEnter(Collider other)
    {
        // changing the jumpStrength property of the Player's Jump component by 20
        other.GetComponent<Jump>().jumpStrength += 20;
    }

    // method to be executed when the Player exits the trampoline
    void OnTriggerExit(Collider other)
    {
        // resetting the jumpStrength property of the Player's Jump component to 12
        other.GetComponent<Jump>().jumpStrength = 12;
    }
}
