/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Description: 
 *      Implements a timer for the game.
 * 
 * How to use:
 *      - Attach the script to the Player
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minutes = 1; // initially assigning a time limit of 1 minute to finish the level
    public float seconds;

    // the update cycle is approximately 0.01 seconds
    void Update()
    {
        // counting the number seconds elapsed in the game
        // by getting the difference of time in between frames
        seconds -= Time.deltaTime;

        // if the value in the seconds variable becomes negative, bring it back to 59
        // then, decrement the number of minutes
        if (seconds <= 0)
        {
            // if there's still minutes left, bring back seconds to 59 so that seconds countdown would start again
            // reduce minutes by one after 60 seconds
            if (minutes > 0)
            {
                seconds += 59;

                minutes--;
            }

            // if there are no minutes left, restart the game level
            else
            {
                // if the timer has stopped, reload the current scene
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
        }

        // checking for timer countdown by printing the time in the console (for debugging purposes)
        print(minutes + ":" + seconds);
    }
}
