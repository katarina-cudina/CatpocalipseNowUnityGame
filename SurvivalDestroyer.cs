using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivalDestroyer : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0f, 0f, -1f);
        if(transform.position.z <=-50)
            Destroy(this.gameObject);
        
    }
}
