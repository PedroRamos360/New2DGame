using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]
    float speed = 7;
    private Rigidbody2D playerRigidbody;

    void Start() {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }
    void Update() {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(x, y, 0);
        MoveCharacter(movement);

        if (y != 0) {
            FlipCharacterY(y);
        }

        if (x != 0) {
            FlipCharacterX(x);
        }
    }

    void MoveCharacter(Vector3 vector) {
        playerRigidbody.MovePosition(transform.position + (vector * Time.deltaTime * speed));
    }

    void FlipCharacterY(float verticalAxis) {
        var rotation = transform.eulerAngles;
        rotation.z = 90 * verticalAxis;
        transform.eulerAngles = rotation;
    }

    void FlipCharacterX(float horizontalAxis) {
        var rotation = transform.eulerAngles;
        rotation.z = -90 * horizontalAxis + 90;
        transform.eulerAngles = rotation;
    }
}
