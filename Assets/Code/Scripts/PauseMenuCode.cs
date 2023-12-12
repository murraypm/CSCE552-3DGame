using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuCode : MonoBehaviour
{
    public GameObject PauseMenu;
    public static bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
        PauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    private void PauseGame()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void QuitGame(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
