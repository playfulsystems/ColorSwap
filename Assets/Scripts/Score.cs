﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public float score = 0;

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = score.ToString();
    }
}
