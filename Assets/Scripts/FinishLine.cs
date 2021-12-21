using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
  public GameObject Endscrn;
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.tag == "Player")
    {
      if (!Endscrn.activeSelf)
      {
        FindObjectOfType<AudioManager>().Play("Complete", false);
        FindObjectOfType<AudioManager>().Stop("Theme");
        FindObjectOfType<AudioManager>().Play("Post", false);
      }
      Endscrn.gameObject.SetActive(true);
    }
  }
}
