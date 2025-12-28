/* **************************************************
 * Author: 
 *      Adrian Josele G. Quional
 * 
 * Description: 
 *      Implements a reset of a specified scene when 
 *      a Trap object is touched by the Player.
 * 
 * How to use:
 *      - Add a Box Collider to the Trap object
 *          (recommended to edit the Prefab)
 *      - Attach the script to the Trap object
 *          (recommended to edit the Prefab)
 *      - Specify the name of the scene to be reloaded
 * **************************************************/

// libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement; // library containing classes for working with the scene

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
