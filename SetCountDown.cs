using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCountDown : MonoBehaviour
{
   private  GameManager GMS;

   public void CountDownStart(){
       GMS = GameObject.Find("GameManager").GetComponent<GameManager>();
       GMS.countDownDone = true;
   }

   
}
