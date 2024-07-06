using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //ctrl + k + d == dosyanmýn düzenli bir formatta kalmasý için dosyada bulunan deðerleri düzenler
    //can operasyonu burdan yonetilicek 
    int healt = 3;


    void Update()
    {
        //can biterse player yok edilecek
        Debug.Log(healt);
        //düþmanýn kuþunu burda algýlanmalý
        //her bir kurþun bir can düþürecek
    }
}
