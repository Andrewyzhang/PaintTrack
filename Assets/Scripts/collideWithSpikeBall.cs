using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideWithSpikeBall : MonoBehaviour
{
    public GameObject player;

    void OnCollisionEnter2D(Collision2D collision){
         if(collision.gameObject.tag == "spikyBall" ){
             player.transform.position = new Vector2 (0, 0);
       }
     }

}
