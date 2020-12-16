using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {
    public GameObject OptionsMenu;
    public GameObject ChoosePlayerMenu;
    public GameObject ControlsMenu;
    public AudioSource selectSound;


    public void PlayPVPMode() {
        selectSound.Play();
        SceneManager.LoadScene("PVPMode");
    }
    public void PlayWavesMode() {
        selectSound.Play();
        gameObject.SetActive(false);
        ChoosePlayerMenu.SetActive(true);
    }

    public void LoadWavesScene() {
        selectSound.Play();
        SceneManager.LoadScene("Waves");
    }

    public void LoadWavesScene2P() {
        selectSound.Play();
        SceneManager.LoadScene("Waves2P");
    }


    public void Options() {
        selectSound.Play();
        gameObject.SetActive(false);
        OptionsMenu.SetActive(true);
    }

    public void Controls() {
        selectSound.Play();
        gameObject.SetActive(false);
        ControlsMenu.SetActive(true);
    }

    public void Back() {
        selectSound.Play();
        gameObject.SetActive(true);
        ChoosePlayerMenu.SetActive(false);
        OptionsMenu.SetActive(false);
        ControlsMenu.SetActive(false);
    }

    public void Exit() {
        Application.Quit();
    }

}
