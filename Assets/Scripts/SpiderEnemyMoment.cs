using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float speed = 7f;//TODO:15 civar� hassas �al���lacak
    void Update()
    {
        this.transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
