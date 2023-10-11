/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program controls the wizard character's 
 *      animation, updated with jumping and attacking
 *      animations.
 * 
 * How to use the script:
 *      - Add the Wizard Prefab
 *      - Setup the virtual camera and camera target 
 *          inside Wizard Prefab
 *      - Setup the animation states via the 
 *          Animator Window (update to include the
 *          jumping and attacking states)
 *      - Attach the script to the Wizard Prefab
 *      - In the CharacterAnim component of the 
 *          Wizard Prefab, put the Animator component
 *          of Wizard Prefab in the Animator field
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    // Animator component selectable in the Inspector
    public Animator animator;

    // variables to hold the numeric ID of the Animator parameters
    int isWalkingHash, isRunningHash, isJumpingHash, isAttackingHash;

    // at the beginning of the game, just get the name of the Animator parameters
    // then transform them into numeric IDs
    void Start()
    {
        // StringToHash method translates the name of the Animator parameter into a numeric ID to optimize the code
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        isJumpingHash = Animator.StringToHash("isJumping");
        isAttackingHash = Animator.StringToHash("isAttacking");
    }

    // continuously get the Bool type parameters for each animation state
    // and continuously check key presses to transition to different animation states
    void Update()
    {
        // GetBool method gets the Boolean value of the Bool type parameter of the Animator Controller Window
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isJumping = animator.GetBool(isJumpingHash);
        bool isAttacking = animator.GetBool(isAttackingHash);

        // GetKey method gets the value of the key pressed/mouse button clicked by the player on the keyboard and mouse
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");
        bool jumpPressed = Input.GetKey("space");
        bool attackClick = Input.GetMouseButtonDown(0);

        // conditional statements to handle transition between animations:

        // ============================== WALKING ==============================
        // if the player is NOT walking AND the W key is pressed,
        // then we turn on the walking animation
        if (!isWalking && forwardPressed)
        {
            animator.SetBool("isWalking", true);
        }

        // if the player is walking AND the W key is NOT pressed,
        // then we turn off the walking animation
        if (isWalking && !forwardPressed)
        {
            animator.SetBool("isWalking", false);
        }
        // =====================================================================

        // ============================== RUNNING ==============================
        // if the player is NOT running AND the left shift AND W key is pressed,
        // then we turn on the running animation
        if (!isRunning && (forwardPressed && runPressed))
        {
            animator.SetBool("isRunning", true);
        }

        // if the player is running AND the left shift OR W key is NOT pressed,
        // then we turn off the running animation
        if (isRunning && (!forwardPressed || !runPressed))
        {
            animator.SetBool("isRunning", false);
        }
        // =====================================================================

        // ============================== JUMPING ==============================
        // if the player is NOT jumping AND the space bar is pressed,
        // then we turn on the jump animation
        if (!isJumping && jumpPressed)
        {
            animator.SetBool("isJumping", true);
        }

        // if the player is jumping AND the space bar is NOT pressed,
        // then we turn off the jump animation
        if (isJumping && !jumpPressed)
        {
            animator.SetBool("isJumping", false);
        }
        // =====================================================================

        // ============================== ATTACKING ==============================
        // if the player is NOT attacking AND the left mouse button is pressed,
        // then we turn on the attack animation
        if (!isAttacking && attackClick)
        {
            animator.SetBool("isAttacking", true);
        }

        // if the player is attacking AND the left mouse button is NOT pressed,
        // then we turn off the attack animation
        if (isAttacking && !attackClick)
        {
            animator.SetBool("isAttacking", false);
        }
        // =======================================================================
    }
}
