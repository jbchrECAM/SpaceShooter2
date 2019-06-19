using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class DamageCollision : MonoBehaviour
{
    Text healthText;
    public int health;
    public float invicibilityTime = 1.5f;
    float cooldownTimer;

    public GameObject score, combo, vies;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        if (health < 0)
            Die();
        else if (cooldownTimer <= 0)
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (gameObject.tag == "Ennemy" && collider.tag == "Ennemy")
            ;
        else if (gameObject.tag == "Ennemy" && collider.tag == "EditorOnly")
            ;
        else if (gameObject.tag == "EditorOnly" && collider.tag == "Ennemy")
            ;
        else if (gameObject.tag == "EditorOnly" && collider.tag == "EditorOnly")
            ;


        else
        {
            cooldownTimer = invicibilityTime;
            //Debug.Log("trigger " );
            health--;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            if (gameObject.tag == "Player")
                score.GetComponent<scoreKill>().resetCombo();
        }             
        
    }

    void Die()
    {
        Destroy(gameObject);
        if (gameObject.tag == "Player")
            score.GetComponent<scoreKill>().GameOver();
        else if (gameObject.tag == "Ennemy")
        {
            score.GetComponent<Text>().text = score.GetComponent<scoreKill>().addPoint().ToString();
            combo.GetComponent<Text>().text = "combo*" + score.GetComponent<scoreKill>().returnCombo();
            vies.GetComponent<Text>().text = "Vies:" + score.GetComponent<scoreKill>().returnHealth();
        }
            
    }

}
