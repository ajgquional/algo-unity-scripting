/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program implements a transition to Level 1
 *      when the start button in the Main Menu is clicked.
 * 
 * How to use the script:
 *      - Attach the script to Start Button object
 *      - Specify in the OnClick() method in the Inspector
 *          that the StartGame() method would be executed
 *          when the Start Button is clicked
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // library to be able to manage the scene

public class StartButton : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
