using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    public float minSpeed = 3f;
    public float maxSpeed = 8f;
    private Rigidbody2D rb;
    private Vector2 randomVelocity;
    public int pointsForDestruction = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {randomVelocity = Random.insideUnitCircle * Random.Range(minSpeed, maxSpeed);
            rb.velocity = randomVelocity;
        }
    }

    [System.Obsolete]
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        { Destroy(gameObject);
          Destroy(other.gameObject);
        }
    }
}