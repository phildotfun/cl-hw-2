using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Name : MonoBehaviour
{


    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        //find the an object that has the Game Manager component and accesses the player name
        gameManager = FindObjectOfType<GameManager>();
        Debug.Log(gameManager.playerName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
