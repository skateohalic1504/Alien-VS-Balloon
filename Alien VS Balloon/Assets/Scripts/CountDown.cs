﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class CountDown : MonoBehaviour
{
    public Text textBox;
    public float timeStart = 0;

    // Start is called before the first frame update
    void Start()
    {
        textBox.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart += Time.deltaTime;
        textBox.text = "Time: " + Mathf.Round(timeStart).ToString();
    }
}
