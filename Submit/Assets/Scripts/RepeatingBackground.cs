using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundHorizontalLength;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        RepositionBackground();
    }

    private void RepositionBackground()
    {
        if (transform.position.x < -groundHorizontalLength)
        {
            Vector2 groundOffset = new Vector2(groundHorizontalLength * 2f, 0);
            transform.position = (Vector2)transform.position + groundOffset;
        }
    }
}
