using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    public AudioSource[] sounds;

    public void Play (string name) {
        AudioSource s = Array.Find(sounds, sound => sound.name == name);
        s.Play();
    }
}
