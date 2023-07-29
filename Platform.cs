using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // public fields specifying the properties of the platform:
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
