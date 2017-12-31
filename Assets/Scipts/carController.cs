using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class carController : MonoBehaviour {


    private float carSpeed = 10.00f;
    public float  maxPos = 2.25f;
    Vector3 position;
    public uiManager ui;
    public AudioManager am;
    public EnemyDestroyer ed;
    bool currentPlatformAndroid = false;
    Rigidbody2D rb;
 
	void Start () {
   
        position = transform.position;

        if (currentPlatformAndroid == true)
        {
            Debug.Log("Android");
        }
        else
        {
            Debug.Log("Windows");
        }
	}

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D> ();

          #if UNITY_ANDROID
                 currentPlatformAndroid = true;
          #else
                  currentPlatformAndroid = false;
          #endif


        am.carSound.Play();
    }
	
	
	void Update () {

        if (currentPlatformAndroid == true)
        {

        }

        else
        {
            position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;

            position.x = Mathf.Clamp(position.x, -2.5f, 2.5f);

            transform.position = position;
        }

        position = transform.position;

        position.x = Mathf.Clamp(position.x, -2.5f, 2.5f);

        transform.position = position;

    }


    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Enemy Car")
        {
            Destroy(gameObject);
            ed.HighScore();
            ed.scoreText.enabled=false;
            ui.gameOverActivated();
            am.carSound.Stop();
            ui.disablePause();
            am.carCrash.Play();

        }

        
    }

    public void MoveLeft()
    {
        rb.velocity = new Vector2 (-carSpeed, 0);
    }
    public void MoveRight()
    {
        rb.velocity = new Vector2(carSpeed, 0);
    }

    public void SetVelocityZero()
    {
        rb.velocity = Vector2.zero;
    }


}
