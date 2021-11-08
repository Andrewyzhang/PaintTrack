using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collideWithGoal : MonoBehaviour
{

    public Text levelText;

    void OnCollisionEnter2D(Collision2D collision){
         if(collision.gameObject.tag == "Goal" ){
             levelText.text = "Level Complete!";
       }
     }
}