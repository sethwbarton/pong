using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;

public class BallTests
{
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator BallStarts()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.

        var go = new GameObject();
        go.AddComponent<Rigidbody2D>();
        // var ball = go.AddComponent<Ball>();
        //
        // ball.Reset();
        //
        yield return null;

        // Assert.AreEqual(new Vector2(0, 0), gameObject.transform.position);
    }
}