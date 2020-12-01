using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WaveCounter : MonoBehaviour {
    [HideInInspector]
    public int waveNumber = 1;

    private int waveNow = 0;

    public GameObject waveCounter;
    public TextMeshProUGUI waveNumberText;

    private void Update() {
        if (waveNow != waveNumber) {
            waveNow = waveNumber;
            waveNumberText.text = waveNumber.ToString();
            waveCounter.SetActive(true);
            Invoke("DeactivateWaveCounter", 1);
        }
    }

    private void DeactivateWaveCounter() {
        waveCounter.SetActive(false);
    }

}
