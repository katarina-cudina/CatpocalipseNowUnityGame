using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivalPlayerController : MonoBehaviour
{
    public int turningForce = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate() {
        if(Input.GetKey(KeyCode.RightArrow)){
            this.gameObject.GetComponent<Rigidbody>().AddForce(turningForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            this.gameObject.GetComponent<Rigidbody>().AddForce(-turningForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
