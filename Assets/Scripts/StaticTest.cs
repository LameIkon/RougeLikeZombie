using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticTest : MonoBehaviour
{

    public static string name = "test";
    public string startingName;
   
    void Start()
    {
        name = startingName;
        Debug.Log(name);
    }

    
    void Update()
    {
        Debug.Log(startingName + " " + name); 
    }
}
