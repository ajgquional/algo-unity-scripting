/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program controls the 3D wizard character's 
 *      movement.
 * 
 * How to use the script:
 *      - Attach the script to the Wizard Prefab
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    // data about walking and running
    public float speed = 5f;        // default walking speed of the character
    public float runSpeed = 9f;     // default running speed of the character
    float targetMovingSpeed;        // desired speed value depending on the character's action
    // note: speed and runSpeed can be any value, just note that running speed should be 1.5-2 times greater than the walking speed

    // variables to control switching from running to walking
    public bool canRun = true;      // to disable running mechanics (such as when the player is tired or injured after a fight)
    public bool isRunning;          // stores data on whether the button responsible for running is pressed or not 

    public KeyCode runningKey = KeyCode.LeftShift;  // stores the code associated with Left Shift key (most gamers use it for running)

    private Rigidbody playerRigidbody; // stores the Rigidbody component of the Player

    // gets the Player's Rigidbody component after being added to the scene
    // Awake method executes once even before the game starts (thus, Awake() is called before Start())
    // Awake method is called when the game object is added to the scene
    void Awake()
    {
        playerRigidbody = this.GetComponent<Rigidbody>();    
    }

    // disabling the cursor when the game starts
    void Start()
    {
        Cursor.visible = false;    
    }

    // implements running mechanics
    // FixedUpdate method is called before the Update method
    // FixedUpdate method is called at a fixed time every 0.02s
    void FixedUpdate()
    {
        // if running is enabled and Left Shift is pressed, make the character run
        if (canRun && Input.GetKey(runningKey))
        {
            isRunning = true;
        }
        else
        {
            isRunning = false;
        }
        // alternative code: isRunning = canRun && Input.GetKey(runningKey);

        // to run, change the speed of the character to running speed; otherwise, bring the speed back to walking speed
        if (isRunning)
        {
            targetMovingSpeed = runSpeed;
        }
        else
        {
            targetMovingSpeed = speed;
        }
        // alternative code: targetmovingSpeed = isRunning ? runSpeed : speed;

        // updating the speed of the character
        playerRigidbody.velocity = transform.rotation * new Vector3(Input.GetAxis("Horizontal"), playerRigidbody.velocity.y, Input.GetAxis("Vertical") * targetMovingSpeed);
        // notes:
        // - X is the value of the keys A or D
        // - Y is the value of the Y coordinate of the character's Rigidbody component
        // - Z is the value of the keys W or D multiplied by the speed of the character

        // rotating the character
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * (100f * Time.deltaTime), Space.Self);
        // notes:
        // - Input.GetAxis("Horizontal") - character will rotate relative to the Y axis to the value entered using the A and D keys
        // - 100f * Time.deltaTime -  to make the rotation speed a little faster by multiplying its vector by the value of Time.deltaTime rather than a fixed number (which will make the character rotate very quickly and sharply)
        // - Space.Self - to make the local coordinate system rotate
    }
}
