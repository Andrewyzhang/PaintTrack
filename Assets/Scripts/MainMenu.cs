using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public Animator transition;
  public float transitionTime = 1f;

  public void SelectLevel(string levelScene)
  {
        SceneManager.LoadScene(levelScene);
  }
  public void PlayGame()
  {
    StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    FindObjectOfType<AudioManager>().Play("Start", false);
  }

  public void NextLevel()
  {
    StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
  }

  IEnumerator LoadLevel(int levelIndex)
  {
    FindObjectOfType<AudioManager>().Stop("Theme");
    transition.SetTrigger("FadeOut");
    GameHandler.respawnPoint = new Vector2(0, 5);

    yield return new WaitForSeconds(transitionTime);

    SceneManager.LoadScene(levelIndex);
    FindObjectOfType<AudioManager>().Play("Theme", false);
  }

}
