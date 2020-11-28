using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour {
    public GameObject enemy;
    private bool enemyInstatiated = true;

    private void Update() {
        if (enemyInstatiated) {
            Invoke("InstatiateEnemy", 2);
            enemyInstatiated = false;
        }
        
    }
    private void InstatiateEnemy() {
        var enemyPositions = new List<Vector3>{
            new Vector3(4.52f, 2.34f, 0),
            new Vector3(-5.5f, 6.05f, 0),
            new Vector3(15.74f, 6.37f, 0),
            new Vector3(4.58f, -4.09f, 0),
            new Vector3(-5.59f, -6.52f, 0),
            new Vector3(17.12f, -6.52f, 0)
        };

        var random = new System.Random();
        int index = random.Next(enemyPositions.Count);
        Quaternion enemyRotation = new Quaternion(0, 0, 0, 0);
        Instantiate(enemy, enemyPositions[index], enemyRotation);
        enemyInstatiated = true;
    }
}
