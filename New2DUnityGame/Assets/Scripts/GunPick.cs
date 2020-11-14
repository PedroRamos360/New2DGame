using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPick : MonoBehaviour {
    public Animator player1Animator;
    public KeyCode pickPlayer1;

    public Animator player2Animator;
    public KeyCode pickPlayer2;
    private void OnTriggerStay2D(Collider2D collision) {
        if (collision.CompareTag("Player1") && Input.GetKeyDown(pickPlayer1)) {
            if (gameObject.tag == "Pistol") {
                PickGun(player1Animator, "PistolPicked", "M4Picked");
            } else if (gameObject.tag == "M4") {
                PickGun(player1Animator, "M4Picked", "PistolPicked");
            }
        }
        if (collision.CompareTag("Player2") && Input.GetKeyDown(pickPlayer2)) {
            if (gameObject.tag == "Pistol") {
                PickGun(player2Animator, "PistolPicked", "M4Picked");
            } else if (gameObject.tag == "M4") {
                PickGun(player2Animator, "M4Picked", "PistolPicked");
            }
        }
    }

    private void PickGun(Animator playerAnimator, string boolToSetTrue, string boolToSetFalse) {
        Destroy(gameObject);
        playerAnimator.SetBool(boolToSetTrue, true);
        playerAnimator.SetBool(boolToSetFalse, false);
        FindObjectOfType<AudioManager>().Play("Pickup");
    }
}
