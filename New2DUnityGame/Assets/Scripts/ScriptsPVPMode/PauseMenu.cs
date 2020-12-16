using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
    public GameObject pauseMenu;
    public KeyCode pauseKey;
    public AudioSource music;

    private bool isPaused = false;

    private void Pause() {
        if (!isPaused) {
            music.pitch = .6f;
            music.volume *= .6f;
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
        isPaused = true;
    }

    public void Resume() {
        music.pitch = 1f;
        music.volume /= .6f;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    public void MainMenu() {
        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1;
    }

    private void Update() {
        if (Input.GetKeyDown(pauseKey)) {
            Pause();
        }
    }
}
