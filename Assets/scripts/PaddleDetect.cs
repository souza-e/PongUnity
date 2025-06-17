using UnityEngine;

public class PaddleDetect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Detecta a colisão com a bola e chama o método SortearDirecao na bola
          Debug.Log ("Bola colidiu com o paddle!");
           
        }
    }
}
