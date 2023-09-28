/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Program description: 
 *      This program implements reset on a specified 
 *      scene when an object is touched by the Player.
 * 
 * How to use the script:
 *      - Add a Box Collider to the object
 *      - Attach the script to the object
 *      - Specify the name of the scene to be reloaded
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement; // library containing containing classes for working with the scene

public class SceneChange : MonoBehaviour
{
    // empty public field containing the name of the scene that needs to be reloaded
    // needs to be specified in the Inspector
    public string sceneName;

    // method to be executed when the Player touches the object
    void OnTriggerEnter(Collider other)
    {
        // reloads the scene (making the Player teleport back to its spawn point)
        EditorSceneManager.LoadScene(sceneName);
    }
}
