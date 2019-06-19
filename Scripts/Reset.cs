using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public Button resetButton;

    // Start is called before the first frame update
    void Start()
    {
        resetButton.onClick.AddListener(ResetScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetScene()
    {
        //SceneManager.UnloadSceneAsync(0);
        SceneManager.LoadScene(0);
    }
}
