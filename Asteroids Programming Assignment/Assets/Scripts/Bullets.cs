using System;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    private float bullet1 = 50f;
    public float speed = 7f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, bullet1);
    }
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Asteroid"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
