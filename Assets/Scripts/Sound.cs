using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    private AudioSource sound;

    void Start() {
        sound = GetComponent<AudioSource>();
    }
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sound.Play();
        }
    }
}
