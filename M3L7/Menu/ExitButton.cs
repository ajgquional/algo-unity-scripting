/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program quits the game when the Exit Button
 *      in the Main Menu is clicked.
 * 
 * How to use the script:
 *      - Attach the script to Exit Button object
 *      - Specify in the OnClick() method in the Inspector
 *          that the ExitGame() method would be executed
 *          when the Exit Button is clicked
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // library to be able to manage the scene

public class ExitButton : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
    }
}
