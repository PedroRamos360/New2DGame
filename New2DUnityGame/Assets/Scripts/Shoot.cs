using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public Transform bulletPosition;
    public GameObject bulletPrefab;
    private Animator animator;

    private void Start() {
        animator = FindObjectOfType<Animator>();
    }
    void Update() {
        if (Input.GetButtonDown("Fire1") && animator.GetBool("PistolPicked")) {
            ShootBullet();
        }
    }

    private void ShootBullet() {
        Instantiate(bulletPrefab, bulletPosition.position, bulletPosition.rotation);
    }
}
