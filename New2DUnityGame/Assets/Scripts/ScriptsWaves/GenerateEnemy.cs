using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour {
    public GameObject enemy;
    private bool enemyInstatiated = true;

    private float timeToGenerateEnemy = 3;
    [HideInInspector]
    public int enemiesInstatiated = 0;

    [HideInInspector]
    public int enemiesKilled = 0;
    private void Start() {
        
    }

    private void Update() {
        if (enemiesKilled >= FindObjectOfType<WaveCounter>().waveNumber * 3) {
            enemiesKilled = 0;
            enemiesInstatiated = 0;
            //if (FindObjectOfType<AIPath>().maxSpeed <= 5) {
            //    //FindObjectOfType<AIPath>().maxSpeed += 0.3f;

            //}
            Debug.Log(FindObjectOfType<AIPath>().maxSpeed);
            FindObjectOfType<WaveCounter>().waveNumber += 1;
            if (timeToGenerateEnemy >= 1.5f) {
                timeToGenerateEnemy -= 0.5f;
            }
            
        }
        if (enemyInstatiated && enemiesInstatiated < FindObjectOfType<WaveCounter>().waveNumber * 3) {
            Invoke("InstantiateEnemy", timeToGenerateEnemy);
            enemiesInstatiated += 1;
            enemyInstatiated = false;
        }
        
    }
    private void InstantiateEnemy() {
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
