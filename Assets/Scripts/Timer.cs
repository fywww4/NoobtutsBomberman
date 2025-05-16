using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    float elapsenTime;
    void Update()
    {
        elapsenTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsenTime / 60);
        int seconds = Mathf.FloorToInt(elapsenTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

