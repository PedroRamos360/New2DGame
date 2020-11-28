using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {
    private GameObject player1;

    [SerializeField]
    float speed = 1;
    private Rigidbody2D enemyRigidbody;
    float x;
    float y;

    private bool up;
    private bool left;
    private bool down;
    private bool right;

    void Start() {
        player1 = FindObjectOfType<PlayerMovement>().Player;
        enemyRigidbody = GetComponent<Rigidbody2D>();
    }
    void Update() {
        up = false;
        left = false;
        down = false;
        right = false;
        // Decisão do movimento
        if (player1.transform.position.x > gameObject.transform.position.x) {
            right = true;
        } else if (player1.transform.position.x < gameObject.transform.position.x) {
            left = true;
        }

        if (player1.transform.position.y > gameObject.transform.position.y) {
            up = true;
        } else if (player1.transform.position.y < gameObject.transform.position.y) {
            down = true;
        }




        // Movimento
        if (up) {
            y = 1;
            FlipEnemyY(y);
        } else if (down) {
            y = -1;
            FlipEnemyY(y);
        } else y = 0;

        if (left) {
            x = -1;
            FlipEnemyX(x);
        } else if (right) {
            x = 1;
            FlipEnemyX(x);
        } else x = 0;

        Vector3 movement = new Vector3(x, y, 0);
        MoveEnemy(movement);
    }

    void MoveEnemy(Vector3 vector) {
        enemyRigidbody.MovePosition(transform.position + (vector * Time.deltaTime * speed));
    }

    void FlipEnemyY(float verticalAxis) {
        var rotation = transform.eulerAngles;
        rotation.z = 90 * verticalAxis;
        transform.eulerAngles = rotation;
    }

    void FlipEnemyX(float horizontalAxis) {
        var rotation = transform.eulerAngles;
        rotation.z = -90 * horizontalAxis + 90;
        transform.eulerAngles = rotation;
    }
}
