using UnityEngine;

public class Bird : MonoBehaviour
{
    public float upForce = 200f;
    private bool isDead = false;
    private Rigidbody2D rb2d;
    private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        Flap();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead && Input.GetMouseButtonDown(0))
        {
            Flap();
        }
    }

    private void Flap()
    {
        rb2d.linearVelocity = Vector2.zero;
        rb2d.AddForce(new Vector2(0, upForce));
        anim.SetTrigger("Flap");
    }

    void OnCollisionEnter2D()
    {
        isDead = true;
        rb2d.linearVelocity = Vector2.zero;
        anim.SetTrigger("Die");
        GameControl.instance.BirdDied();
    }
}
