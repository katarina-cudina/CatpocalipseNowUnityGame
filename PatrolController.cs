using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PatrolController : MonoBehaviour {
	/* 
     Vector3 firstPosition;
     Vector3 secondPosition;
	public float speed = 100;
	int currentPoint = 0;
	// Use this for initialization
	void Start () {
		firstPosition = transform.position;
        secondPosition = new Vector3(firstPosition.x + 200f, firstPosition.y, firstPosition.z);
		currentPoint=0;
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	private void FixedUpdate() {
		if(currentPoint == 0){
			currentPoint++;
            transform.position= Vector3.MoveTowards(transform.position, secondPosition, speed *Time.deltaTime);
		}
        else if(currentPoint == 1)
        {
            transform.position= Vector3.MoveTowards(transform.position, firstPosition, speed *Time.deltaTime);
            
        }
        Debug.Log(transform.position.x);
		
		if(currentPoint > 1){
				currentPoint=0;
                
		}
	} */
public float rightLimit = 8f;
Vector3 movement;
public float leftLimit = -7.5f;
public float speed = 2.0f;
public int direction = 1;
void Update () {
if (transform.position.x > rightLimit) {
direction = -1;

}

else if (transform.position.x < leftLimit) {

direction = 1;

}

movement = Vector3.right * direction * speed * Time.deltaTime; 

transform.Translate(movement); 

}
	
}
