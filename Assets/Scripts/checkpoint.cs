using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkpoint : MonoBehaviour
{

    public Animator anim;

    void Start() {
      anim = GetComponent<Animator>();
      anim.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Vector2 pointupdate; // local variable to store position of the current game object

        if (other.tag == "Player") // filter the objects that collide with the checkpoint. You can assign the tag in the inspector
        {
          // Grab the X and Y values of the checkpoint position
          pointupdate = new Vector2( transform.position.x,transform.position.y);
          // Update the _respawnPoint varaible in GameManager
          GameHandler.respawnPoint = pointupdate;

          anim.enabled = true;

          // anim.Play("checkpointReached");
          // anim.Play("checkpointWaving");
        }
      }

}
