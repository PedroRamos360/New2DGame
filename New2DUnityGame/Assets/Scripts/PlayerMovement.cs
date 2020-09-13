using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]
    float speed = 7;
    private Rigidbody2D playerRigidbody;
    float x;
    float y;

    public KeyCode up;
    public KeyCode left;
    public KeyCode down;
    public KeyCode right;

    void Start() {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }
    void Update() {
        if (Input.GetKey(up)) {
            y = 1;
            FlipCharacterY(y);
        } else if (Input.GetKey(down)) {
            y = -1;
            FlipCharacterY(y);
        } else y = 0;

        if (Input.GetKey(left)) {
            x = -1;
            FlipCharacterX(x);
        } else if (Input.GetKey(right)) {
            x = 1;
            FlipCharacterX(x);
        } else x = 0;

        Vector3 movement = new Vector3(x, y, 0);
        MoveCharacter(movement);


        /*
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
        */
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
