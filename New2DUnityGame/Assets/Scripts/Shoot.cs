using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public Transform bulletPosition;
    public GameObject bulletPrefab;
    public Animator animator;

    private bool shootCooldownOver = true;

    public KeyCode shoot;

    void Update() {
        if (Input.GetKey(shoot) && animator.GetBool("PistolPicked") && shootCooldownOver) {
            shootCooldownOver = false;
            Invoke("SetCooldownOver", 0.5f);
            ShootBullet();
        }
    }

    private void ShootBullet() {
        Instantiate(bulletPrefab, bulletPosition.position, bulletPosition.rotation);
    }

    private void SetCooldownOver() {
        shootCooldownOver = true;
    }

}
