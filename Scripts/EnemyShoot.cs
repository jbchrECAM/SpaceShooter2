using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Vector2 bulletOffset = new Vector3(0, 0.5f);
    public GameObject bulletPrefab;
    int bulletLayer;

    public float fireDelay = 0.5f, fireRange;
    float cooldownTimer = 0;

    public Transform player;
    public float speed;

    void Start()
    {
        bulletLayer = gameObject.layer;
    }

    // Update is called once per frame
    void Update()
    {        
        if (player == null)
        {
            // Find the player's ship!
            GameObject go = GameObject.FindWithTag("Player");

            if (go != null)
            {
                player = go.transform;
            }
        }


        cooldownTimer -= Time.deltaTime;

        if (cooldownTimer <= 0 /*&& player != null && Vector3.Distance(transform.position, player.position) < fireRange*/)
        {
            // SHOOT!
            //Debug.Log ("Enemy Pew!");
            cooldownTimer = fireDelay;

            Vector3 offset = transform.rotation * bulletOffset;
           
            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
            bulletGO.layer = bulletLayer;
            bulletGO.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, (Mathf.Abs(bulletGO.transform.position.y)+2) * -speed));
            
        }
    }
}
