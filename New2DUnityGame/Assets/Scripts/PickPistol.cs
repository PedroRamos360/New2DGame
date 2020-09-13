using UnityEngine;

public class PickPistol : MonoBehaviour {
    public GameObject pistol;
    public Animator animator;

    public KeyCode pick;

    private void OnTriggerStay2D(Collider2D collision) {
        Debug.Log(collision.CompareTag("Pistol"));
        Debug.Log(Input.GetKeyDown(pick));
        if (collision.CompareTag("Pistol") && Input.GetKeyDown(pick)) {
            Destroy(pistol);
            animator.SetBool("PistolPicked", true);
        }
        if (collision.CompareTag("Pistol2") && Input.GetKeyDown(pick)) {
            Destroy(pistol);
            animator.SetBool("PistolPicked", true);
        }
    }
}
