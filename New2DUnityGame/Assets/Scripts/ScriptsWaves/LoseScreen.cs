using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour {
    public GameObject music;

    private void Update() {
        if (gameObject.activeSelf) {
            Destroy(music);
        }
    }

    public void TryAgain() {
        Time.timeScale = 1;
        SceneManager.LoadScene("Waves");
    }

    public void TryAgainP2() {
        Time.timeScale = 1;
        SceneManager.LoadScene("Waves");
    }

    public void MainMenu() {
        Time.timeScale = 1;
        SceneManager.LoadScene("StartMenu");
    }
}
