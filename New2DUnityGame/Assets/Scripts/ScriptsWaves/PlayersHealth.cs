using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayersHealth : MonoBehaviour {
    public TextMeshProUGUI p1healthText;
    public TextMeshProUGUI p2healthText;

    [HideInInspector]
    public int p1health = 100;
    [HideInInspector]
    public int p2health = 100;

    void Update() {
        p1healthText.text = p1health.ToString();
        if (p2healthText != null) {
            p2healthText.text = p2health.ToString();
        }
    }
}
