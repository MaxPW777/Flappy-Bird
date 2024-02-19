using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private Gamemanager gamemanager;

    private void Awake() {
        gamemanager = FindObjectOfType<Gamemanager>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        gamemanager.increment_score();
    }
}
