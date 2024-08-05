using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 5f; // Velocidade inicial
    public float speedIncrease = 0.1f; // Quanto a velocidade aumenta a cada segundo
    public float turnSpeed = 200f; // Velocidade de virada
    public float descentSpeed = 1f; // Velocidade de descida
    public float turnInterval = 2f; // Intervalo de tempo para mudança de direção
    public float repositionInterval = 5f; // Intervalo de tempo para reposicionar
    //public float minX, maxX; // Limites da pista na direção X

    private Rigidbody2D rb;
    private float nextTurnTime;
    private float nextRepositionTime;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        nextTurnTime = Time.time + turnInterval;
        nextRepositionTime = Time.time + repositionInterval;
    }

    void Update()
    {
        // Aumenta a velocidade gradualmente
        speed += speedIncrease * Time.deltaTime;

        // Descida automática
        rb.velocity = new Vector2(0, -descentSpeed);

        /* Virada aleatória
        if (Time.time > nextTurnTime)
        {
            TurnRandomly();
            nextTurnTime = Time.time + turnInterval;
        }

        // Reposiciona aleatoriamente
        if (Time.time > nextRepositionTime)
        {
            RepositionRandomly();
            nextRepositionTime = Time.time + repositionInterval;
        }*/
    }

    /*void TurnRandomly()
    {
        float turnDirection = Random.Range(-1f, 1f); // Aleatoriamente -1 ou 1
        rb.angularVelocity = turnDirection * turnSpeed * Time.deltaTime;
    }

    void RepositionRandomly()
    {
        float randomX = Random.Range(minX, maxX); // Gera uma posição aleatória na largura da pista
        transform.position = new Vector3(randomX, transform.position.y, transform.position.z);
    }*/
}