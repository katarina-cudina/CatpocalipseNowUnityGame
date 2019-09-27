using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StarController : MonoBehaviour
{
    Text scoreText;
    System.Random rnd;
   
    private void Start() {
        
    }
    void Update()
    {   
        transform.Rotate(90*Time.deltaTime, 0f, 0f);
    }
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player")
        {
            rnd = new System.Random();
            SoundManager.PickupSound(rnd.Next(1,5));
            Destroy(gameObject);
            GameObject.Find("Score").GetComponent<Score>().score += 10;
        }
    }
}
