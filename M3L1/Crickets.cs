/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program simply prints the text "crickets"
 *      every frame.
 * 
 * How to use the script:
 *      - Attach the script to the Main Camera
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crickets : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // no need to put anything here
    }

    // Update is called once per frame
    void Update()
    {
        // prints the word "crickets" every frame 
        print("crickets");
    }
}
