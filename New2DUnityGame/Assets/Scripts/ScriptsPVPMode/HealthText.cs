using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthText : MonoBehaviour {
    public TextMeshProUGUI p1HealthText;
    public TextMeshProUGUI p2HealthText;

    void Update() {
        if (FindObjectOfType<PlayerDeath>()) {
            p1HealthText.text = FindObjectOfType<PlayerDeath>().player1health.ToString();
            p2HealthText.text = FindObjectOfType<PlayerDeath>().player2health.ToString();
        }
    }
}
