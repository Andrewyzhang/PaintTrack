using System;
using UnityEngine.Audio;
using UnityEngine;
using Random = UnityEngine.Random;

public class AudioManager : MonoBehaviour
{
  public Sound[] sounds;

  public static AudioManager instance;

  [Header("Pitch")]
  public float minPitchValue;
  public float maxPitchValue;

  [Header("Volume")]
  public float minVolumeValue;
  public float maxVolumeValue;

  // Start is called before the first frame update
  void Awake()
  {

    if (instance == null)
      instance = this;
    else
    {
      Destroy(gameObject);
      return;
    }

    DontDestroyOnLoad(gameObject);

    foreach (Sound s in sounds)
    {
      s.source = gameObject.AddComponent<AudioSource>();
      s.source.clip = s.clip;

      s.source.volume = s.volume;
      s.source.pitch = s.pitch;
      s.source.loop = s.loop;
    }
  }

  void Start()
  {
    Play("Theme", false);
  }

  // Add sound with FindObjectOfType<AudioManager>().Play("Name of Sound", false);
  public void Play(string name, bool vary)
  {
    Sound s = Array.Find(sounds, sound => sound.name == name);
    if (s == null)
    {
      Debug.LogWarning("Sound: " + name + " not found");
      return;
    }
    if (vary)
      RandomizeSound(s);

    s.source.Play();
  }

  public void Stop(string name)
  {
    Sound s = Array.Find(sounds, sound => sound.name == name);
    if (s == null)
    {
      Debug.LogWarning("Sound: " + name + " not found");
      return;
    }
    s.source.Stop();
  }

  private void RandomizeSound(Sound s)
  {
    s.source.pitch = Random.Range(minPitchValue, maxPitchValue);
    s.source.volume = Random.Range(minVolumeValue, maxVolumeValue);
  }
}
