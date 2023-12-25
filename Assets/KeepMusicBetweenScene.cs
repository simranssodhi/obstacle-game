using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepMusicBetweenScene : MonoBehaviour
{
  void Awake()
  {
      DontDestroyOnLoad(transform.gameObject); // ensures the audio gameObject is not destroyed with scene transitioning.
  }
}
