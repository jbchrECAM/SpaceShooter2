using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public GameObject pseudo, EntrezPseudo, grotruk, Menu, camera;
    public Button startButton;
    
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(TaskOnClick);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void TaskOnClick()
    {
        pseudo.GetComponent<Text>().text += EntrezPseudo.GetComponent<Text>().text;
        grotruk.SetActive(true);
        Menu.SetActive(false);
        //grotruk.transform.localPosition = new Vector3(11.5f, 126.8f, 4);
        //camera.transform.localPosition = new Vector3(128, 257, 1);
    }


}
