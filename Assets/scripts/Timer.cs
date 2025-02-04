using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Unity.VisualScripting;

public class Timer : MonoBehaviour
{
    private bool speedrunningModeEnabled = true;

    [SerializeField] GameObject parentPanel;

    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currentTime;

/*
    [Header("Format Settings")]
    public float currentTime;*/

    public static Timer instance;
    void Awake(){
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        if (!speedrunningModeEnabled){
            parentPanel.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        currentTime += Time.deltaTime;
        timerText.text = "Time - " + currentTime.ToString("0.00");
    }
}
