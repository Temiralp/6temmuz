using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //ctrl + k + d == dosyanm�n d�zenli bir formatta kalmas� i�in dosyada bulunan de�erleri d�zenler
    //can operasyonu burdan yonetilicek 
    int healt = 3;


    void Update()
    {
        //can biterse player yok edilecek
        Debug.Log(healt);
        //d��man�n ku�unu burda alg�lanmal�
        //her bir kur�un bir can d���recek
    }
}
