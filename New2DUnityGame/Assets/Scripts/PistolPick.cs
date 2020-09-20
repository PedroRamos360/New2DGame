using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolPick : MonoBehaviour {
    public Animator player1Animator;
    public KeyCode pickPlayer1;

    public Animator player2Animator;
    public KeyCode pickPlayer2;
    private void OnTriggerStay2D(Collider2D collision) {
        if (collision.CompareTag("Player1") && Input.GetKeyDown(pickPlayer1)) {
            Destroy(gameObject);
            player1Animator.SetBool("PistolPicked", true);
            FindObjectOfType<AudioManager>().Play("Pickup");
        }
        if (collision.CompareTag("Player2") && Input.GetKeyDown(pickPlayer2)) {
            Destroy(gameObject);
            player2Animator.SetBool("PistolPicked", true);
            FindObjectOfType<AudioManager>().Play("Pickup");
        }
    }
}
