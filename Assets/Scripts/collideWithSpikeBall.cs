using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideWithSpikeBall : MonoBehaviour
{
  public GameObject player;

  void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.tag == "spikyBall")
    {
      FindObjectOfType<AudioManager>().Play("Death", false);
      player.transform.position = GameHandler.respawnPoint;
      GameHandler.lives--;
    }
  }

}
