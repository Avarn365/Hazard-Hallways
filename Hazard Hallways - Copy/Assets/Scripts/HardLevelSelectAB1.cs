﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardLevelSelectAB1 : MonoBehaviour
{
    public void Start()
    {
        Cursor.visible = !Cursor.visible;
        Cursor.lockState = CursorLockMode.None;
    }

    public void NextButton()
    {
        SceneManager.LoadScene("Hard Level Select AB2");
    }
}