using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    //public BoardManager boardScript;
    public BoardManagerMarco boardScriptMarco;

    private int level = 3;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
        //boardScript = GetComponent<BoardManager>();
        boardScriptMarco = GetComponent<BoardManagerMarco>();
        InitGame();
    }


    void InitGame() 
    {
        //boardScript.SetupScene(level);
        boardScriptMarco.SetupScene(level);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
