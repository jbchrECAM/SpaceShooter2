using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Move : MonoBehaviour
{
    public float speed, moveForce = 5;
    Rigidbody2D playerBody;

    public Vector2 playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        playerPosition = transform.localPosition;
        playerBody = this.GetComponent<Rigidbody2D>();
   
    }

    void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 pos = playerPosition;
        Vector2 Velocity = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical"))*speed*Time.deltaTime;

        pos += Velocity;

        playerPosition = pos;
        transform.localPosition = playerPosition;
        if (playerPosition.x < -2)
            playerPosition = new Vector2(-2, playerPosition.y);
        if (playerPosition.x > 2)
            playerPosition = new Vector2(2, playerPosition.y);

        if (playerPosition.y < -4)
            playerPosition = new Vector2(playerPosition.x, -4);
        if (playerPosition.y > 4.5f)
            playerPosition = new Vector2(playerPosition.x, 4.5f);
    }
}
