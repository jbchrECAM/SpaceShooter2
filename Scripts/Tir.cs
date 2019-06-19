using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tir : MonoBehaviour
{
    public Vector3 tirOffset = new Vector3(0, 0.5f, 0);
    public GameObject tirPrefab;
    public AudioClip playerShotSound;
    public Button tirButton;


    int tirLayer;
    public float fireDelay = 0.25f;
    float cooldownTimer = 0;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        tirLayer = gameObject.layer;
        tirButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;



        if (/*Input.GetKey(KeyCode.Space) &&*/ cooldownTimer <= 0)
        {
            
            cooldownTimer = fireDelay;

            Vector3 offset = transform.rotation * tirOffset;

            GameObject bulletGO = (GameObject)Instantiate(tirPrefab, transform.position + offset, new Quaternion(transform.rotation.x,transform.rotation.y,transform.rotation.z, transform.rotation.w));
            bulletGO.layer = tirLayer;
            bulletGO.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,(Mathf.Abs(bulletGO.transform.position.y)+2) * speed));
            
            
        }

    }

    void TaskOnClick()
    {
        if (/*Input.GetKey(KeyCode.Space) &&*/ cooldownTimer <= 0)
        {

            cooldownTimer = fireDelay;

            Vector3 offset = transform.rotation * tirOffset;

            GameObject bulletGO = (GameObject)Instantiate(tirPrefab, transform.position + offset, new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w));
            bulletGO.layer = tirLayer;
            bulletGO.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, (Mathf.Abs(bulletGO.transform.position.y) + 2) * speed));


        }
    }

    
}
