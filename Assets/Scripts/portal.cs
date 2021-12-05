using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
    public GameObject destinationPortal;
    public GameObject player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") // filter the objects that collide with the checkpoint. You can assign the tag in the inspector
        {
            player.transform.position = destinationPortal.transform.position;
        }
      }
}
