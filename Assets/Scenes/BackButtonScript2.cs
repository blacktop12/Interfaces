using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonScript2 : MonoBehaviour
{
    public void backToPrevScene()
    {
        SceneManager.LoadScene("Scene2");
    }
}
