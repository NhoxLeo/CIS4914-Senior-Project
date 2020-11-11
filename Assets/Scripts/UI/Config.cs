﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Config : MonoBehaviour {
    // Start is called before the first frame update
    public InputField popInput;
    public InputField infectedInput;
    public InputField transmissionInput;
    public InputField numDaysInput;
    public InputField taskNumInput;
    public InputField taskDurInput;

    public static uint initPop = 0;
    public static uint initNumInfected = 0;
    public static float transRate = 0f;
    public static uint numDays = 3;
    public static uint tasksPerDay = 6;
    public static uint taskDuration = 5;

    private void ValueChange() {
        //put numeric constraint
        try {
            initPop = Convert.ToUInt32(popInput.text.ToString());
            initNumInfected = Convert.ToUInt32(infectedInput.text.ToString());
            transRate = Convert.ToSingle(transmissionInput.text.ToString());
            tasksPerDay = Convert.ToUInt32(numDaysInput.text.ToString());
            taskDuration = Convert.ToUInt32(taskNumInput.text.ToString());
            numDays = Convert.ToUInt32(taskDurInput.text.ToString());
        }
        catch (FormatException) {
            Debug.Log("given input is not a numeric value");
        }

    }


    public void OpenGame() {
        Debug.Log("PLEASE");
        ValueChange();
        Debug.Log(initPop);
        Debug.Log(initNumInfected);
        Debug.Log(transRate);
        Debug.Log(numDays);
        Debug.Log(tasksPerDay);
        Debug.Log(taskDuration);
        if (initPop == 0 || initNumInfected == 0 || transRate == 0) {
            Debug.Log("Popup window with stop message");
        }
        else {
            SceneManager.LoadScene(1);
        }

    }

}
