using UnityEngine;

public class CarroController : MonoBehaviour
{
    public float speed = 5f;
    public float turnSpeed = 200f;
    private float horizontal;
    private float vertical;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Captura as entradas do jogador
        float moveInput = 0f;
        float turnInput = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveInput = 1f; // Movimento para frente
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveInput = -1f; // Movimento para trás
        }

        if (Input.GetKey(KeyCode.A))
        {
            turnInput = 1f; // Rotacionar para a esquerda
        }
        else if (Input.GetKey(KeyCode.D))
        {
            turnInput = -1f; // Rotacionar para a direita
        }

        // Movimenta e rotaciona o carro
        MoveCar(moveInput, turnInput);
    }

    private void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(speed * Time.fixedDeltaTime * horizontal, speed * Time.fixedDeltaTime * vertical, 0);
    }

    private void MoveCar(float moveInput, float turnInput)
    {
        Vector2 moveDirection = transform.up * moveInput * speed * Time.deltaTime;
        rb.MovePosition(rb.position + moveDirection);

        float turnAmount = turnInput * turnSpeed * Time.deltaTime;
        rb.MoveRotation(rb.rotation - turnAmount);
    }
}