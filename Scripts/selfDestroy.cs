using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class selfDestroy : MonoBehaviour
{

    public float timer=1f;
    void Start()
    {
        
    }
 
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
            Destroy(gameObject);
    }
}
