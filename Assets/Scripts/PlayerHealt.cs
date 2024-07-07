using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;

    void Start()
    {
        Debug.Log("Player Health: " + health);
    }

    void Update()
    {
        if (health <= 0)
        {
            Debug.Log("Player has been destroyed");
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy2"))
        {
            health--;
            Debug.Log("Player Health: " + health);
        }
        else if (collision.gameObject.CompareTag("mermi2"))
        {
            health--;
            Debug.Log("Player Health: " + health);
            Destroy(collision.gameObject);
        }
    }
}
