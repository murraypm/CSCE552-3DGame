using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuCode : MonoBehaviour
{
    public GameObject PauseMenu;
    public static bool isPaused = false;
    [SerializeField] private GameObject Options;
    [SerializeField] private GameObject PauseStuff;
    [SerializeField] private GameObject HowToPlay;

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
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                ResumeGame();
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
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
        Options.SetActive(false);
        HowToPlay.SetActive(false);
        PauseStuff.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;


        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void QuitGame(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menus");
    }
}
