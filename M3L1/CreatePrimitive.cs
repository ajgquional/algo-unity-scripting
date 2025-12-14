/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Description: 
 *      Demonstrates how primitives can be
 *      created using a script.
 * 
 * How to use:
 *      - Attach the script to the Main Camera
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrimitive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // creates a figure resembling Steve from Minecraft at the beginning of the game
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 0, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-0.5f, 1, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0.5f, 1, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0.5f, 2, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-0.5f, 2, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // no need to put anything here
    }
}
