﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class YourTotalScore : MonoBehaviour
{
    public TextMeshProUGUI ScoreTextResult;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ScoreTextResult.text = "SCORE " + the_ball_mechanics.score;
    }
}