using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BulletBehavior : MonoBehaviour {
    [SerializeField]
    private float speed = 1;
    void Start() {
        Rigidbody2D rb = FindObjectOfType<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        Invoke("DestroyBullet", 3);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (!collision.CompareTag("Player")) {
            DestroyBullet();
        }
    }

    private void DestroyBullet() {
        Destroy(gameObject);
    }
}
