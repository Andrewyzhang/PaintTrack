using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public Animator transition;
  public float transitionTime = 1f;
  public void PlayGame()
  {
    StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
  }

  IEnumerator LoadLevel(int levelIndex)
  {
    transition.SetTrigger("FadeOut");
    GameHandler.respawnPoint = new Vector2(0,5);

    yield return new WaitForSeconds(transitionTime);

    SceneManager.LoadScene(levelIndex);
  }

}
