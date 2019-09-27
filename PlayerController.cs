using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private  GameManager GMS;

    public Rigidbody rb; 
    public float forwardForce = 1000f, turningForce = 100f, jumpingForce = 100f;
    bool isGrounded = false;

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "ground" && isGrounded == false)
        {
                isGrounded = true;
                rb.angularDrag = 5f;

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        GMS = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }
    private void Update() {
        if(Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            rb.angularDrag = 20f;
            isGrounded = false;
        }
        
    }

    // Update is called once per frame
    void FixedUpdate() //for physics stuff
    {
        if(GMS.countDownDone == true)
        {
            rb.AddForce(0, 0, forwardForce*Time.deltaTime);

        if(Input.GetKey(KeyCode.RightArrow)){
            rb.AddForce(turningForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            rb.AddForce(-turningForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
            FindObjectOfType<GameManager>().EndGame();
    }

        }

        
}
