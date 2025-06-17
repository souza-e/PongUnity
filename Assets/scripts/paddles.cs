using System;
using UnityEngine;

public class paddles : MonoBehaviour
{
    public float speed = 5f; // Velocidade do paddle

    [SerializeField] private Rigidbody2D rb1, rb2; // Referências aos Rigidbody2D dos paddles

    [SerializeField] Transform wallUp, wallDown;



    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Update()
    {

        PaddleController1(); // Chama o controlador do paddle 1
        PaddleController2(); // Chama o controlador do paddle 2

    }


    void PaddleController1()
    {


        float YMax = wallUp.position.y; // Obtém a posição máxima do paddle
        float YMin = wallDown.position.y; // Obtém a posição mínima do paddle

        // Debug.Log("YMax: " + YMax + ", YMin: " + YMin); // Loga os valores de YMax e YMin para depuração



        // rb1.position = new Vector2(rb1.position.x, Mathf.Clamp(rb1.position.y, YMin, YMax)); // Restringe o paddle dentro dos limites
        float moveInput = Input.GetAxis("Vertical"); // Obtém a entrada vertical (teclas de seta ou WASD)
        Vector2 movement = new Vector2(0, moveInput) * speed * Time.deltaTime; // Calcula o movimento do paddle
        rb1.MovePosition(rb1.position = new Vector2(rb1.position.x, Mathf.Clamp(rb1.position.y, YMin + 2f, YMax - 2f)) + movement); // Move o paddle na direção calculada

        // Debug.Log("velocidade da paddle é " + rb1.linearVelocity.magnitude); /// Loga a velocidade do paddle




    }

    void PaddleController2()
    {
        float YMax = wallUp.position.y; // Obtém a posição máxima do paddle
        float YMin = wallDown.position.y; // Obtém a posição mínima do paddle


        float moveInput = Input.GetAxis("Vertical2"); // Obtém a entrada vertical para o segundo paddle
        Vector2 movement = new Vector2(0, moveInput) * speed * Time.deltaTime; // Calcula o movimento do paddle
        rb2.MovePosition(rb2.position = new Vector2(rb2.position.x, Mathf.Clamp(rb2.position.y, YMin + 2f, YMax - 2f)) + movement); // Move o paddle na direção calculada


        //Mathf.Clamp (VALOR QUE PRECISA SER LIMITADO, VALOR MÍNIMO, VALOR MÁXIMO) 



    }





}
