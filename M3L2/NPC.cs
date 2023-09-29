/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program makes the "NPC" move constantly
 *      (every frame) in a straight line.
 * 
 * How to use the script:
 *      - Create a plane where the NPC would be placed
 *      - Create a cube NPC (you may add color and material)
 *      - Attach the script to the NPC
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // NPC Health
    public int health = 5;

    // NPC Level
    public int level = 1;

    // NPC Speed
    public float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        // NPC's health is updated once according to its level in the game
        health = health + level;
        print("NPC Health: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        // creating a newPosition variable which stores the current position of the NPC
        Vector3 newPosition = transform.position;

        // calculating the z position using the set speed and the time between frames
        // Physics formula for reference: distance = speed * time
        newPosition.z += speed * Time.deltaTime;
        // note: if the NPC is intended to be moved across the x- or even y-direction,
        //  change newPosition.z to newPosition.x or newPosition.y

        // assigning the calculated new position to the position of the NPC
        transform.position = newPosition;
    }
}
