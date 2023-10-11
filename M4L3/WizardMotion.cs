/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program controls the mixing of the wizard's
 *      animation.
 * 
 * How to use the script:
 *      - Setup the animation states and blend trees
 *      - Attach the script to the Wizard Prefab
 *      - Specify the Animator component of the Wizard
 *          in the Animator field of the Inspector
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardMotion : MonoBehaviour
{
    // gets the Animator component of the character
    public Animator animator;

    // to change velX and velY parameters (that were created via Animator)
    void Update()
    {
        animator.SetFloat("velX", Input.GetAxis("Horizontal"), 0.1f, Time.deltaTime);
        animator.SetFloat("velY", Input.GetAxis("Vertical"), 0.1f, Time.deltaTime);
        // notes:
        // - velX and velY - the parameters to be set
        // - Input.GetAxis() - the value to assign to the parameter
        // - 0.1f - the time within which the parameter value will change to the specified one
        // - Time.deltaTime - the time between frames
    }
}
