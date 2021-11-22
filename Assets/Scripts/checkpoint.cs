using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkpoint : MonoBehaviour
{

    // void OnCollisionEnter2D(Collision2D collision){
    //      if(collision.gameObject.tag == "checkpoint" ){
    //          GameHandler.respawnPoint = checkpoint.transform.position;
    //          GameHandler.respawnPoint = new Vector2(0,1000);
    //          transform.position = new Vector2(0,0);
    //    }
    //  }

    void OnTriggerEnter2D(Collider2D other)
    {
        Vector2 pointupdate; // local variable to store position of the current game object

        if (other.tag == "Player") // filter the objects that collide with the checkpoint. You can assign the tag in the inspector
        {
          // Grab the X and Y values of the checkpoint position
          pointupdate = new Vector2( transform.position.x,transform.position.y);
          // Update the _respawnPoint varaible in GameManager
          GameHandler.respawnPoint = pointupdate;

        }
      }

}
