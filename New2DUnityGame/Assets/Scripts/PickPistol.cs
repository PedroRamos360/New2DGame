using UnityEngine;

public class PickPistol : MonoBehaviour {
    public GameObject pistol;
    private Animator animator;

    private void Start() {
        animator = FindObjectOfType<Animator>();
    }
    private void OnTriggerStay2D(Collider2D collision) {
        if (collision.CompareTag("Pistol") && Input.GetKeyDown("f")) {
            Destroy(pistol);
            animator.SetBool("PistolPicked", true);
        }
    }
}
