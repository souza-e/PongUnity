using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed; // Velocidade da bola, ajustada para ser mais suave com o tempo
    private Rigidbody2D rb;



    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        SortearDirecao();


    }



    void Update()
    {



        Debug.DrawLine(transform.position, transform.position + (Vector3)rb.linearVelocity.normalized * 2f, Color.red);


        if (rb.linearVelocity != Vector2.zero)
            rb.linearVelocity = rb.linearVelocity.normalized * speed ; // Normaliza a velocidade e aplica o deltaTime para suavizar o movimento
       
      //  Debug.Log("Velocidade da bola: " + rb.linearVelocity.magnitude);

        // Verifica se a bola saiu da tela e sorteia uma nova direção



    }

    void SortearDirecao()
    {


        //float EixoX = Random.Range(-2f, 2f);
        float EixoY = Random.Range(-2f, 2f);
        float EixoX = 10f;

        rb.linearVelocity = new Vector2(EixoX, EixoY); // Normaliza a direção e multiplica pela velocidade





        Debug.Log("Direção sorteada: " + rb.linearVelocity);

        Debug.Log("EixoX: " + EixoX + ", EixoY: " + EixoY);



    }




}



