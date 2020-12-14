using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour {
    public AudioMixer audioMixer;

    public void SetMusicVolume(float volume) {
        if (volume > -40) {
            audioMixer.SetFloat("Music", volume);
        } else {
            audioMixer.SetFloat("Music", -80);
        }
        
    }

    public void SetGameSoundsVolume(float volume) {
        if (volume > -40) {
            audioMixer.SetFloat("GameSounds", volume);
        } else {
            audioMixer.SetFloat("GameSounds", -80);
        }
    }
}
