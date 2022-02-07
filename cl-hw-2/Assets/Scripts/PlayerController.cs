using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public KeyCode moveLeft;
    public KeyCode moveRight;
    public float xMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(moveLeft))
        {
            transform.position -= new Vector3(xMove, 0, 0);
        }
        else if (Input.GetKeyDown(moveRight))
        {
            transform.position += new Vector3(xMove, 0, 0);
        }
    }
}
