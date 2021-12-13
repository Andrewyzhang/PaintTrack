using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterVolume : MonoBehaviour
{
  public void setVolume(float volume)
  {
    AudioListener.volume = volume;
  }
}
