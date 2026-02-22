/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Description: 
 *      Similar to the original Trampoline script which 
 *      increases the jump strength of the  Player when 
 *      a Trampoline object is touched, except that this 
 *      time, the script has been updated considering the 
 *      Wizard's new default jump strength.
 * 
 * How to use:
 *      - Remove the old Trampoline script from the 
 *          Trampoline object and attach this new script 
 *          to that object; or
 *      - Update the old Trampoline script by updating 
 *          the value of the jumpStrength property to 50
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineWizard : MonoBehaviour
{
    // method to be executed when the Wizard enters the trampoline
    void OnTriggerEnter(Collider other)
    {
        // changing the jumpStrength property of the Wizard's Jump component by 50
        other.GetComponent<Jump>().jumpStrength += 50;
    }

    // method to be executed when the Wizard exits the trampoline
    void OnTriggerExit(Collider other)
    {
        // resetting the jumpStrength property of the Wizard's Jump component to 12
        other.GetComponent<Jump>().jumpStrength = 12;
    }
}
