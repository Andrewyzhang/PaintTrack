using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
  public GameObject Endscrn;
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.tag == "Player")
    {
      FindObjectOfType<AudioManager>().Play("Complete", false);
      FindObjectOfType<AudioManager>().Stop("Theme");
      Endscrn.gameObject.SetActive(true);
    }
  }
}
