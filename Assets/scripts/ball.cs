using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(1, 0.5f).normalized * speed;
    }

   void OnCollisionEnter2D(Collision2D collision)
{
    Debug.Log("Colidiu com: " + collision.gameObject.name);

    if (collision.gameObject.name.Contains("Paddle"))
    {
        Debug.Log("Rebateu na raquete!");

        float y = (transform.position.y - collision.transform.position.y) / collision.collider.bounds.size.y;
        Vector2 direction = new Vector2(rb.linearVelocity.x * -1, y).normalized;
        rb.linearVelocity = direction * speed;
    }
}
}
