using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static float score = 0;

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = Score.score.ToString();
    }
}
