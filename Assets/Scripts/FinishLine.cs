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
      if (!Endscrn.activeSelf)
      {
        FindObjectOfType<AudioManager>().Play("Complete", false);
        FindObjectOfType<AudioManager>().Stop("Theme");

        StartCoroutine(delay());
      }
      Endscrn.gameObject.SetActive(true);
    }
  }

  IEnumerator delay()
  {
    yield return new WaitForSeconds(1.5f);
    FindObjectOfType<AudioManager>().Play("Post", false);
  }
}
