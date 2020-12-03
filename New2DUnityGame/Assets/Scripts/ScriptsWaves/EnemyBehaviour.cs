using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyBehaviour : MonoBehaviour {
    public AIPath aipath;

    void Update() {
        var rotation = transform.eulerAngles;
        if (aipath.desiredVelocity.x >= 0.1f) {
            rotation.z = 0;
        } else if (aipath.desiredVelocity.x < -0.1f) {
            rotation.z = 180;
        }
        transform.eulerAngles = rotation;
    }
}
