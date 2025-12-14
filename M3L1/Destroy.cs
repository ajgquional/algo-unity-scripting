/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Description: 
 *      Demonstrates how a game object can be destroyed 
 *      using a script.
 * 
 * How to use:
 *      - Create any primitive (shape) and place it 
 *          anywhere on the scene
 *      - Attach the script to that primitive
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // destroys the primitive that the script is attached to at the beginning of the game
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        // no need to put anything here
    }
}
