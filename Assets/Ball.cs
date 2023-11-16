using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D body;
    public float speed;
    private Vector2 _initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        _initialPosition = body.position;
        Launch();
    }

    public void Reset()
    {
        body.position = _initialPosition;
    }

    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        body.velocity = new Vector2(speed * x, speed * y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
