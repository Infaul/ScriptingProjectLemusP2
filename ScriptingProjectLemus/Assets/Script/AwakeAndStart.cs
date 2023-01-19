using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
        //References between scripts, initialization
    {
        Debug.Log("Awake called.");
    }


    void Start()
        //Once script component is enabled
    // Update is called once per frame
    {
        Debug.Log("Start Called.");
    }
}
