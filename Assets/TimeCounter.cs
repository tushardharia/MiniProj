﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public GameObject textdisplay;
    public GameObject Boss;
    public int secondsLeft = 10;
    public bool takingAway = false;

    void Start()
    {
        textdisplay.GetComponent<Text>().text = "Time Left - 00:" +secondsLeft;
    }

    void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimeTake());
        }

        else if (secondsLeft == 0)
        {
            textdisplay.SetActive(false);
            Boss.SetActive(true);
        }
    }

    IEnumerator TimeTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        textdisplay.GetComponent<Text>().text = "Time Left - 00:" +secondsLeft;
        takingAway = false;
    }
}
