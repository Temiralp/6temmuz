using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10.0f;

    void Update()
    {
        // Kur�unu ileri do�ru hareket ettir
        transform.position += Vector3.right * (speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            //      gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("enemy2"))
        {
            // E�er �arp�lan obje "Enemy" etikete sahipse hem kur�unu hem de d��man� pasif hale getir
            //gameObject.SetActive(false);
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
