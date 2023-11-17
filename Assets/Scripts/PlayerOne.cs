using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOne : MonoBehaviour
{

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += new Vector3(0, Constants.MovementSpeed, 0);
        }
        if (Input.GetKey("s"))
        {
            transform.position += new Vector3(0, -Constants.MovementSpeed, 0);
        }
        
    }
}
