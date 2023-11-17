using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D body;
    public float speed;
    private Vector2 _initialPosition;

    public void Reset()
    {
        body.position = _initialPosition;
    }

    // Start is called before the first frame update
    private void Start()
    {
        _initialPosition = transform.position;
        Launch();
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        body.velocity = new Vector2(speed * x, speed * y);
    }
}