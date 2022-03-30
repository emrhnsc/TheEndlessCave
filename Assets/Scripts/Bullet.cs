using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed = 10f;
    Rigidbody2D rb2d;
    PlayerMovement player;
    float xSpeed;

    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
        rb2d = GetComponent<Rigidbody2D>();
        xSpeed = player.transform.localScale.x * bulletSpeed;
    }

    void Update()
    {
        rb2d.velocity = new Vector2(xSpeed, 0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
}
