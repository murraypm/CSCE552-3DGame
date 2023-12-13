using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLoseManager : MonoBehaviour
{
    static public bool isLose = false;
    public static bool isWin = false;
    [SerializeField] private GameObject WinLoseScreen;
    [SerializeField] private GameObject WinImage;
    [SerializeField] private GameObject LoseImage;
    [SerializeField] private AudioSource victory;
    [SerializeField] private AudioSource defeat;

    // Start is called before the first frame update
    void Start()
    {
        WinLoseScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey(KeyCode.V))
            {
                Win();
            }
            if (Input.GetKey(KeyCode.C))
            {
                Lose();
            }
    }

    public void Win()
    {
        screen();
        isWin = true;
        LoseImage.SetActive(false);
        WinImage.SetActive(true);
        victory.Play();
    }

    public void Lose()
    {
        screen();
        isLose = true;
        WinImage.SetActive(false);
        LoseImage.SetActive(true);
        defeat.Play();
    }

    public void PlayAgain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menus");
    }

    public void QuitGame()
    {
        Debug.Log("Quiting ...");
        Time.timeScale = 1f;
        Application.Quit();
    }

    private void screen()
    {
        WinLoseScreen.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
