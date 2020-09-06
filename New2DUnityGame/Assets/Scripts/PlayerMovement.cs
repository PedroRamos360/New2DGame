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
    }

    void MoveCharacter(Vector3 vector) {
        playerRigidbody.MovePosition(transform.position + (vector * Time.deltaTime * speed));
    }
}
