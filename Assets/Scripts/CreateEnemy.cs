using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    public GameObject enemyPrefab; // Kur�un prefab� referans�

    public float fireRate = 1.0f; // Kur�un olu�turma aral���
    public float moveSpeed = 5.0f; // D��man hareket h�z�

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
