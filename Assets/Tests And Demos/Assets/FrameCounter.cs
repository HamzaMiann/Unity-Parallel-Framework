﻿using UnityEngine;
using UnityEngine.UI;

// taken from:
// https://answers.unity.com/questions/1189486/how-to-see-fps-frames-per-second.html
public class FrameCounter : MonoBehaviour
{
    public Text fpsText;
    public float deltaTime;

    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        fpsText.text = Mathf.Ceil(fps).ToString();
    }
}