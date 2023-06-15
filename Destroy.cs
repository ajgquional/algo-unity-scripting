using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // destroys the primitive that the script is attached to at the beginning of the game
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
