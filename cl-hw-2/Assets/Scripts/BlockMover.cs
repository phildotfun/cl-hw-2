using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMover : MonoBehaviour
{
    //moves the block down the screen every X amount of seconds

    public float secondWait = 1.0f;
    public float distance = 1.0f;
    float timeCount = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        //wait a certain a set amount of seconds to run the MoveDown method
        InvokeRepeating("MoveDown", secondWait, secondWait);
    }

    void MoveDown()
    {
        //move the block down every few seconds
        transform.position = transform.position + new Vector3(0, distance, 0);
    }
}
