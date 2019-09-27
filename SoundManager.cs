using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip pickup1, pickup2, pickup3, pickup4, song;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
       pickup1 = Resources.Load<AudioClip>("star1"); 
       pickup2 = Resources.Load<AudioClip>("star2"); 
       pickup3 = Resources.Load<AudioClip>("star3"); 
       pickup4 = Resources.Load<AudioClip>("star4"); 

       audioSrc = GetComponent<AudioSource>();

    }
    public static void PickupSound(int i)
    {
        switch(i){
            case 1:
            audioSrc.PlayOneShot(pickup1);
                break;
            case 2:
            audioSrc.PlayOneShot(pickup2);
                break;
            case 3:
            audioSrc.PlayOneShot(pickup3);
                break;
            case 4:
            audioSrc.PlayOneShot(pickup4);
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
