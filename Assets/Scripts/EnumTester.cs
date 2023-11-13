using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumTester : MonoBehaviour
{

    public VideogameCharacters characters;

    void Start()
    {

        characters = (VideogameCharacters)Random.Range(0, 8);

        Debug.Log(characters);

        

        switch (characters) {

            case VideogameCharacters.Sonic:
                Debug.Log("Gotta go fast");
                break;

            case VideogameCharacters.Link:
                Debug.Log("HYAAAA");
                break;

            case VideogameCharacters.Dark_Souls:
                Debug.Log("Git Gud");
                break;

            default:
                Debug.Log("<ERROR>: Charactor doesn't speak");
                break; 
        }
        
    }


    void Update()
    {
        
    }

}

public enum VideogameCharacters
{ 
    Sonic,
    Link,
    Mario,
    Samus,
    Ganon,
    Dark_Souls

}