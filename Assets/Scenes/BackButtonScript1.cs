﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonScript1 : MonoBehaviour
{
    public void backToPrevScene()
    {
        SceneManager.LoadScene("Scene1");
    }
}