using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {
    public GameObject OptionsMenu;
    public void PlayPVPMode() {
        SceneManager.LoadScene("PVPMode");
    }
    public void PlayPVEMode() {
        SceneManager.LoadScene("PVEMode");

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
