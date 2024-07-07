using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    float enemySpeed = 1.2f;
    float frequency = 5.8f; // hareketin frekansý
    float amplitude = 2.0f; // hareketin genliði
    float time = 0.5f; // zaman hesaplamak için

    void Update()
    {
        MoveEnemy();
    }

    void MoveEnemy()
    {
        time += Time.deltaTime * enemySpeed;

        // x ve y pozisyonunu hesapla
        float x = -time; // x pozisyonu sürekli artacak
        float y = Mathf.Sin(time * frequency) * amplitude; // y pozisyonu sin dalgasýna göre deðiþecek

        // pozisyonu güncelle
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
