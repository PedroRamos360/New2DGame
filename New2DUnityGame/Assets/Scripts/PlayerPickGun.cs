using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickGun : MonoBehaviour {
    public KeyCode pickKey;
    public Animator playerAnimator;
    public GameObject m4;
    public GameObject pistol;

    private void OnTriggerStay2D(Collider2D collision) {
        if (collision.CompareTag("Pistol") && Input.GetKeyDown(pickKey)) {
            if (playerAnimator.GetBool("M4Picked")) {
                Instantiate(m4, gameObject.transform.position, new Quaternion(0,0,0,0));
            } else if (playerAnimator.GetBool("PistolPicked")) {
                Instantiate(pistol, gameObject.transform.position, new Quaternion(0, 0, 0, 0));
            }
            PickGun(playerAnimator, "PistolPicked", "M4Picked", collision.gameObject);
        } else if (collision.CompareTag("M4") && Input.GetKeyDown(pickKey)) {
            if (playerAnimator.GetBool("PistolPicked")) {
                Instantiate(pistol, gameObject.transform.position, new Quaternion(0, 0, 0, 0));
            } else if (playerAnimator.GetBool("M4Picked")) {
                Instantiate(m4, gameObject.transform.position, new Quaternion(0, 0, 0, 0));
            }
            PickGun(playerAnimator, "M4Picked", "PistolPicked", collision.gameObject);
        }
    }

    private void PickGun(Animator playerAnimator, string boolToSetTrue, string boolToSetFalse, GameObject gun) {
        Destroy(gun);
        playerAnimator.SetBool(boolToSetTrue, true);
        playerAnimator.SetBool(boolToSetFalse, false);
        FindObjectOfType<AudioManager>().Play("Pickup");
    }
}
