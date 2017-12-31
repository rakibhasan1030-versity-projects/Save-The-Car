using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCarMove : MonoBehaviour
{

    EnemyDestroyer ed;

    public float speed = 10.00f;

    void Start()
    {
       // Rigidbody rb = GetComponent<Rigidbody>();
 
    }

    void Update()
    {

        transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
        
    }

}
