using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstEnemyGun : MonoBehaviour
{
    public GameObject bulletPrefab; // Kur�un prefab� referans�
    public float bulletSpeed = 15.0f;
    public float fireRate = 1.0f; // Kur�un olu�turma aral���
    public float moveSpeed = 5.0f; // D��man hareket h�z�

    void Start()
    {
        InvokeRepeating("EnemyFire", 0.5f, fireRate);
    }

    void Update()
    {
    }

    void EnemyFire()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        bullet.GetComponent<Bullet>().speed = bulletSpeed;
        Debug.Log("Fire");
    }
}
