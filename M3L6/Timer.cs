/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program improves the previous timer program.
 *      Specifically, code is added to round off the
 *      value of seconds, and libraries are added to 
 *      work with text in the UI. Additionally, the default
 *      time for level completion has been increased to 
 *      2 minutes.
 * 
 * How to use the script:
 *      - Replace the previous Timer script with this one
  *     - Link the Timer Text object
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // library to be able to work with the game scene
using UnityEngine.UI;               // library needed to work with the interface
using TMPro;                        // library needed to work with text

public class Timer : MonoBehaviour
{
    public int minutes = 2; // initially assigning a time limit of 2 minutes to finish the level
    public float seconds;

    // link to the TextMeshProGUI component of the timer
    public TextMeshProUGUI timerText;

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

        // rounding the value of seconds to integers before displaying them on the screen
        int roundSeconds = Mathf.RoundToInt(seconds);
        timerText.text = minutes + ":" + roundSeconds;
    }
}
