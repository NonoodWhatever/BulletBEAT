using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetLost : MonoBehaviour
{
    // Emerc Exit Program button.
    void Update()
    {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
                print("Leaving with ESC");
            }
    }
    // Literally taken from my old project, as it is the most basic code ever

}

