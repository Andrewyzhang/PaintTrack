using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideWithSpikeBall : MonoBehaviour
{
  public GameObject player;

  Vector3 cameraInitialPosition;
	public float shakeMagnetude = 0.05f, shakeTime = 0.5f;
	public Camera mainCamera;

	public void ShakeIt()
	{
		cameraInitialPosition = mainCamera.transform.position;
		InvokeRepeating ("StartCameraShaking", 0f, 0.005f);
		Invoke ("StopCameraShaking", shakeTime);
	}

	void StartCameraShaking()
	{
		float cameraShakingOffsetX = Random.value * shakeMagnetude * 2 - shakeMagnetude;
		float cameraShakingOffsetY = Random.value * shakeMagnetude * 2 - shakeMagnetude;
		Vector3 cameraIntermadiatePosition = mainCamera.transform.position;
		cameraIntermadiatePosition.x += cameraShakingOffsetX;
		cameraIntermadiatePosition.y += cameraShakingOffsetY;
		mainCamera.transform.position = cameraIntermadiatePosition;
	}

	void StopCameraShaking()
	{
		CancelInvoke ("StartCameraShaking");
		mainCamera.transform.position = cameraInitialPosition;
	}

  void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.tag == "spikyBall")
    {
      ShakeIt();
      FindObjectOfType<AudioManager>().Play("Death", false);
      player.transform.position = GameHandler.respawnPoint;
      GameHandler.lives--;
    }
  }

}
