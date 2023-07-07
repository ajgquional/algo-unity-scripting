using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement; // library containing containing classes for working with the scene

public class SceneChange : MonoBehaviour
{
    // empty public field containing the name of the scene that needs to be reloaded
    public string sceneName;

    // method to be executed when the Player touches a spike
    void OnTriggerEnter(Collider other)
    {
        // reloads the scene (Player then teleports back to its spawn point)
        EditorSceneManager.LoadScene(sceneName);
    }
}
