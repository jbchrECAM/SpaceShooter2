using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern : MonoBehaviour
{
    private Vector2 mobPosition;
    public float timerPattern=0;
    public int stepPattern;
    public float speed;
    public GameObject nextWave;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mobPosition = transform.localPosition;
        timerPattern += Time.deltaTime;
        if (timerPattern > 3.5f)
        {
            if(stepPattern<11)
                stepPattern++;
            timerPattern = 0;
        }

        switch (stepPattern)
        {
            case 1:
                mobPosition += new Vector2(-0.4f*speed, 0);
                break;

            case 2:
                mobPosition += new Vector2(-0.3f * speed, -0.35f * speed);
                break;
            case 3:
                mobPosition += new Vector2(0.5f*speed, 0);
                break;
            case 4:
                mobPosition += new Vector2(-2*speed, 2*speed);
                break;
            case 5:
                Destroy(gameObject);
                nextWave.SetActive(true);
                nextWave.GetComponent<Pattern>().enabled = true;
                break;
            case 6:
                mobPosition += new Vector2(0, -speed);
                break;
            case 7:
                mobPosition += new Vector2(0.5f*speed, 0);
                break;
            case 8:
                mobPosition += new Vector2(-0.5f*speed, 0);
                break;
            case 9:
                mobPosition += new Vector2(2.5f * speed, 2.5f * speed);
                    break;
            case 10:
                Destroy(gameObject);
                nextWave.SetActive(true);
                nextWave.GetComponent<Pattern>().enabled = true;
                break;
            case 11:
                mobPosition += new Vector2(0, -2*speed);
                break;
            default:
                //mobPosition = new Vector2(0, 0);
                break;

        }

        transform.localPosition = mobPosition;
        

        
    }
}
