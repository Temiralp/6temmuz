using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    public GameObject enemyPrefab; // Kurþun prefabý referansý

    public float fireRate = 1.0f; // Kurþun oluþturma aralýðý
    public float moveSpeed = 5.0f; // Düþman hareket hýzý

    void Start()
    {
        InvokeRepeating("EnemyObject", 0.5f, fireRate);
    }

    void Update()
    {
    }

    void EnemyObject()
    {
        GameObject bullet = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        Debug.Log("Fire111");
    }
}
