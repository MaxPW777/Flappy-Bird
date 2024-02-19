using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreChanger : MonoBehaviour
{
    [SerializeField] private Gamemanager gamemanager;
    private TextMeshProUGUI text;

    void Start(){
        text = GetComponent<TextMeshProUGUI>();
    }

    void Update() {
        
    }
}
