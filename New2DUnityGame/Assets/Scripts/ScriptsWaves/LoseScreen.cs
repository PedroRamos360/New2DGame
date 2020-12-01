using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour {
    
    public void TryAgain() {
        SceneManager.LoadScene("Waves");
        Time.timeScale = 1;
    }

    public void MainMenu() {
        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1;
    }
}
