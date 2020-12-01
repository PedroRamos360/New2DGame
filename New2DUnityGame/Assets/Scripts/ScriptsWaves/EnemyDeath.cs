using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour {
    private int enemyHealth = 3;


    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Bullet") {
            enemyHealth -= 1;
            if (enemyHealth <= 0) {
                FindObjectOfType<GenerateEnemy>().enemiesKilled += 1;
                Destroy(gameObject);
            }
        }
    }
}
