using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class BulletBehavior : MonoBehaviour {
    [SerializeField]
    private float speed = 1;
    bool pvpmode;
    void Start() {
        pvpmode = SceneManager.GetActiveScene().name == "PVPMode";
        Rigidbody2D rb = FindObjectOfType<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        Invoke("DestroyBullet", 3);
    }
    
    private void OnTriggerEnter2D(Collider2D collision) {
        if (pvpmode) {
            if (collision.CompareTag("Player1")) {
                DestroyBullet();
                FindObjectOfType<PlayerDeath>().player1health -= 20;
                FindObjectOfType<AudioManager>().Play("DamageSound");
            } else if (collision.CompareTag("Player2")) {
                DestroyBullet();
                FindObjectOfType<PlayerDeath>().player2health -= 20;
                FindObjectOfType<AudioManager>().Play("DamageSound");
            } else {
                DestroyBullet();
            }
        } else {
            DestroyBullet();
        }
    }

    private void DestroyBullet() {
        Destroy(gameObject);
    }
}
