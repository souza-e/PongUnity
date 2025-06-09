using UnityEngine;

public class paddles : MonoBehaviour
{
    public float speed = 5f; // Velocidade do paddle

    [SerializeField] private Rigidbody2D rb1, rb2; // Referências aos Rigidbody2D dos paddles


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

        PaddleController1(); // Chama o controlador do paddle 1
        PaddleController2(); // Chama o controlador do paddle 2

    }


    void PaddleController1()
    {
        float moveInput = Input.GetAxis("Vertical"); // Obtém a entrada vertical (teclas de seta ou WASD)

        Vector2 movement = new Vector2(0, moveInput) * speed * Time.deltaTime; // Calcula o movimento do paddle
        rb1.MovePosition(rb1.position + movement); // Move o paddle na direção calculada

        // Implementar a lógica do controlador de paddle aqui
        // Por exemplo, mover o paddle com as teclas de seta ou WASD
        // e detectar colisões com a bola

    }

    void PaddleController2()
    {
        float moveInput = Input.GetAxis("Vertical2"); // Obtém a entrada vertical para o segundo paddle

        Vector2 movement = new Vector2(0, moveInput) * speed * Time.deltaTime; // Calcula o movimento do paddle
        rb2.MovePosition(rb2.position + movement); // Move o paddle na direção calculada

        // Implementar a lógica do controlador de paddle aqui
        // Por exemplo, mover o paddle com as teclas de seta ou WASD
        // e detectar colisões com a bola

    }


}
