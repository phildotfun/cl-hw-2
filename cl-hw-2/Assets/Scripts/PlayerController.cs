using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public KeyCode moveLeft;
    public KeyCode moveRight;
    public float xMove;

    public KeyCode launch;

    //shoot the object up
    public float m_Thurst = 5.0f;
    Rigidbody2D m_Rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
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
        else if (Input.GetKeyDown(launch))
        {
            m_Rigidbody2D.AddForce(transform.up * m_Thurst, ForceMode2D.Impulse);
        }
    }
}
