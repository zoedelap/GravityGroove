using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitListener : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            print("exiting application");
            Application.Quit();
        }
    }
}
