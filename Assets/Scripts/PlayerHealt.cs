using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3; // Player'�n ba�lang�� can de�eri

    void Start()
    {
        // �lk can de�erini yazd�r
        Debug.Log("Player Health: " + health);
    }

    void Update()
    {
        // Can de�eri 0 oldu�unda player'� yok et
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
            // Can de�erini azalt
            health--;
            Debug.Log("Player Health: " + health);
        }
    }
}
