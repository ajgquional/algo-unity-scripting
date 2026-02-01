/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Description: 
 *      Animates the button and the blue gate: when the button 
 *      is pressed, the gate would open.
 * 
 * How to use:
 *      - Add a button near the blue gate (Button prefab can
 *          be acquired from the Prefabs folder of Level_1, or
 *          get the Button instance at the back of one of the
 *          buildings in the topmost level)
 *      - Create an Animation for both the Button and the Blue 
 *          Gates
 *      - Attach the script to the Cylinder.001 object inside
 *          Button
 *      - In the Button component of the Cylinder.001 object, 
 *          set the Button field to be the animator component 
 *          of Cylinder.001 and the ToOpen field to the animator 
 *          component of Blue Gates
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    // refers to the Animator component of the game objects referenced to in the Inspector
    public Animator button;     // Animator component of the button game object
    public Animator toOpen;     // Animator component of the game object to be opened

    // Animator component of the button and gate is disabled at the beginning of the game
    void Start()
    {
        button.enabled = false;
        toOpen.enabled = false;
    }

    // when the button (where the script is attached to) is collided with,
    // the Animator components of both the button and the gate would be enabled
    private void OnTriggerEnter(Collider other)
    {
        button.enabled = true;
        toOpen.enabled = true;
    }
}
