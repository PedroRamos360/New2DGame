using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public int player = 1;

    public Transform bulletPosition;
    public GameObject bulletPrefab;
    public Animator animator;

    public KeyCode shoot;

    void Update() {
        if (Input.GetKeyDown(shoot) && animator.GetBool("PistolPicked")) {
            ShootBullet();
        }
    }

    private void ShootBullet() {
        Instantiate(bulletPrefab, bulletPosition.position, bulletPosition.rotation);
    }
}
