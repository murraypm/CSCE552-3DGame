using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {
        //SceneManager.LoadScene("GameSceneName");
        print("TODO add game scene name");
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
