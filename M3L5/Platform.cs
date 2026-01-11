/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Description: 
 *      Implements the mechanics for the lift:
 *          - Takes the Player up or down until a 
 *              specified point 
 *          - Only be activated when the Player steps 
 *              on it
 * 
 * How to use:
 *      - Setup the lift: there should be a Platform object
 *          and two stop points
 *      - Setup a "PlatformStop" tag and assign it to the
 *          two stop points (consequently, assign a "Player"
 *          tag to the Player object)
 *      - Attach the script to the Platform object
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // public fields specifying the properties of the Platform:
    public int speed;           // speed of the platform
    public Vector3 direction;   // direction of the platform
    public bool isActive;       // status of the platform

    // platform would continuously move up or down, if it is active
    void Update()
    {
        if (isActive)
        {
            transform.position += direction * speed * Time.deltaTime;
        }
    }

    // method to execute if the platform is touched by the player or either of the stopping points
    void OnTriggerEnter(Collider other)
    {
        // if the platform touched either of the stopping points, it would reverse its direction of motion
        // that is, platform touching the stopping point above would make the platform go down, and vice-versa
        if (other.tag == "PlatformStop")
        {
            direction *= -1;
        }

        // if the platform is touched by the player, then the platform becomes active
        if (other.tag == "Player")
        {
            isActive = true;
        }
    }

    // method to execute if the player goes out of the platform
    // the platform gets deactivated when the player goes out of the platform
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isActive = false;
        }
    }
}
