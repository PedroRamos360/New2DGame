using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateGun : MonoBehaviour {
    public GameObject m4;

    private void Start() {
        Invoke("InstatiateGun", 10);
    }
    private void InstatiateGun() {
        var gunPositions = new List<Vector3>{
            new Vector3(4.52f, 2.34f, 0),
            new Vector3(-5.5f, 6.05f, 0),
            new Vector3(15.74f, 6.37f, 0),
            new Vector3(4.58f, -4.09f, 0),
            new Vector3(-5.59f, -6.52f, 0),
            new Vector3(17.12f, -6.52f, 0)
        };

        var random = new System.Random();
        int index = random.Next(gunPositions.Count);
        Quaternion gunRotation = new Quaternion(0, 0, 0, 0);
        Instantiate(m4, gunPositions[index], gunRotation);
    }
}
