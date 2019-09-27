using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseLevel : MonoBehaviour
{
    public static bool isPaused = false; 
    public GameObject pausePanelUI;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        
    }
    void Pause()
    {
        pausePanelUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

    }
    public void Resume()
    {
        pausePanelUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);

    }
    public void QuitGame(){
        Debug.Log("QUIT");
        Application.Quit();
    }

}
