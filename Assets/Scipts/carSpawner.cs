using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawner : MonoBehaviour {
    int carNo;
    public GameObject[] cars;
    public float maxPos = 2.0f;
    public float delayTimer = 1.0f;
    float timer;
	// Use this for initialization
	void Start () {
        timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 carPos = new Vector3(Random.Range(-2.0f, 2.06f), transform.position.y, transform.position.z);
            carNo = Random.Range(0, 7);
            Instantiate(cars[carNo], carPos, transform.rotation);
            timer = delayTimer;
        }

    }
}
