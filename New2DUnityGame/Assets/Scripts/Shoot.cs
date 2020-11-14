using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public Transform bulletPosition;
    public GameObject bulletPrefab;
    public Animator animator;

    private bool shootCooldownOverPistol = true;
    private bool shootCooldownOverM4 = true;

    public KeyCode shoot;

    void Update() {
        if (Input.GetKey(shoot) && animator.GetBool("PistolPicked") && shootCooldownOverPistol) {
            shootCooldownOverPistol = false;
            Invoke("SetCooldownOverPistol", 0.5f);
            ShootBullet();
        }
        if (Input.GetKey(shoot) && animator.GetBool("M4Picked") && shootCooldownOverM4) {
            shootCooldownOverM4 = false;
            Invoke("SetCooldownOverM4", 0.2f);
            ShootBullet();
        }
    }

    private void ShootBullet() {
        Instantiate(bulletPrefab, bulletPosition.position, bulletPosition.rotation);
    }

    private void SetCooldownOverPistol() {
        shootCooldownOverPistol = true;
    }

    private void SetCooldownOverM4() {
        shootCooldownOverM4 = true;
    }

}
