using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;



    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(speed, 0f);

    }



    void Update()
    {






    }





}



