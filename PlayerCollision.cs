using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Obstacle"){
            Debug.Log("BOOM");
            FindObjectOfType<GameManager>().EndGame();
            

        }  
    }
}
