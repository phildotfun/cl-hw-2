using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public KeyCode rotLeft;     //press D to rotate right
    public KeyCode rotRight;    //press A to rotate left

 
    public float timeCount = 0.0f;

    int blockRot = 0;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateLeft();
        RotateRight();
    }

    void RotateLeft()
    {
        //rotates the block to the left on each press
        if (Input.GetKeyDown(rotLeft))
        {
            {
                blockRot = blockRot + 90;
            }
        }

        //convert object rotation to quarternion
        //have it slerp between its current rot and target rotation
        Quaternion target = Quaternion.Euler(0, 0, blockRot);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * timeCount);
    }

    void RotateRight()
    {
        //rotates the block to the left on each press
        if (Input.GetKeyDown(rotRight))
        {
            {
                blockRot = blockRot - 90;
            }
        }

        //convert object rotation to quarternion
        //have it slerp between its current rot and target rotation
        Quaternion target = Quaternion.Euler(0, 0, blockRot);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * timeCount);
    }
}
