using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {
    public GameObject OptionsMenu;
    public GameObject ChoosePlayerMenu;
    public void PlayPVPMode() {
        SceneManager.LoadScene("PVPMode");
    }
    public void PlayWavesMode() {
        gameObject.SetActive(false);
        ChoosePlayerMenu.SetActive(true);
    }

    public void LoadWavesScene() {
        SceneManager.LoadScene("Waves");
    }

    public void LoadWavesScene2P() {
        SceneManager.LoadScene("Waves2P");
    }


    public void Options() {
        gameObject.SetActive(false);
        OptionsMenu.SetActive(true);
    }

    public void Back() {
        gameObject.SetActive(true);
        OptionsMenu.SetActive(false);
    }

}
