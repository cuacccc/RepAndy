using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    public Light LuzLinterna;
    public bool ActiveLight;
    public bool LinternaEnMano;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L) && LinternaEnMano == true)
        {
            ActiveLight = !ActiveLight;

            if (ActiveLight == true) 
            {
                LuzLinterna.enabled = true;
            }

            if (ActiveLight == false)
            {
                LuzLinterna.enabled=false;
            }
        }

            

    }
}
