/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program implements the operation of the button
 *      and blue gates (i.e. when the button is pressed, the
 *      gate would open).
 * 
 * How to use the script:
 *      - Add a button near the blue gates (Button prefab can
 *          be acquired from the Prefabs folder of Level_1)
 *      - Create an Animation for both the Button and the Blue 
 *          Gates
 *      - Attach the script to the Cylinder.001 object inside
 *          Button
 *      - Click the Cylinder.001 object, look at the Button 
 *          component in the Inspector, then select the Cylinder.001
 *          in the Button field, and Blue Gates in the ToOpen field
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
