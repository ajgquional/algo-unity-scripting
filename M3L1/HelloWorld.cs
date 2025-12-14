/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Description: 
 *      Simply prints the text "Hello, World!"
 *      to the console.
 * 
 * How to use:
 *      - Attach the script to the Main Camera
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // output to the console greetings to the world
        print("Hello, World!");
    }

    // Update is called once per frame
    void Update()
    {
        // for this introductory script, no need to put anything here
    }
}
