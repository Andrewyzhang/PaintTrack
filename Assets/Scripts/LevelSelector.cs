using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelSelector : MonoBehaviour
{
    public void Select(string levelName)
    {
        SceneManager.LoadScene(levelName);
        GameHandler.respawnPoint = new Vector2(0,5);
    }

}
