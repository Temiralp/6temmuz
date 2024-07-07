using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondBullet : MonoBehaviour
{
    public float speed = -10.0f;

    void Update()
    {
        transform.position += Vector3.right * (speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
     
    }
}
