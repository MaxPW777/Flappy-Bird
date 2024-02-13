using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    private int score = 0;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void GameOver(){
        audioSource.Play();
    }

    public void increment_score(){
        score++;
    }

    public int getScore() => score;
}
