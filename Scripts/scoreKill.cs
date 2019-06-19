using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;

public class scoreKill : MonoBehaviour
{
    public GameObject gameOver, pseudo;
    public static string playerName;
    public static int playerScore; 
    public int playerScoreOld;
    private int score = 0, combo=0, health=3;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int addPoint()
    {
        combo++;
        return score += 5 * combo;
    }

    public void resetCombo()
    {
        combo = 0;
        health--;
    }

    public string returnCombo()
    {       
        return combo.ToString();
    }
    public string returnHealth()
    {
        return health.ToString();
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        playerScore = score;
        playerName = pseudo.GetComponent<Text>().text;
        PutToFirebase();

    }

    private void PutToFirebase()
    {
        User user = new User();
        RestClient.Put("https://space-shooter-f23b8.firebaseio.com/" + playerName + ".json", user);
    }

    private User GetFromFirebase()
    {
        RestClient.Get<User>("https://space-shooter-f23b8.firebaseio.com/" + playerName + ".json").Then(response =>
        {
            return response;
        });
        return null;
    }
}
