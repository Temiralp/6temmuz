using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    float enemySpeed = 1.2f;
    float frequency = 5.8f; // hareketin frekans�
    float amplitude = 2.0f; // hareketin genli�i
    float time = 0.5f; // zaman hesaplamak i�in

    void Update()
    {
        MoveEnemy();
    }

    void MoveEnemy()
    {
        time += Time.deltaTime * enemySpeed;

        // x ve y pozisyonunu hesapla
        float x = -time; // x pozisyonu s�rekli artacak
        float y = Mathf.Sin(time * frequency) * amplitude; // y pozisyonu sin dalgas�na g�re de�i�ecek

        // pozisyonu g�ncelle
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
