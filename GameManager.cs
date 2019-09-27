using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject countdown;
    public bool countDownDone = false;
    bool gameHasEnded = false;
    public GameObject completeLevelUI;

    public float restartDelay = 1f;
    
    public void CompleteLevel(){
        completeLevelUI.SetActive(true);
    }
    public void EndGame(){
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
        
    }
    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    private void Start() {
       
    }
    private void Update(){
        if(countDownDone == true)
            countdown.SetActive(false);
    }
}
