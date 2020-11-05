using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectScript : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "BttnComencemos":
            SceneManager.LoadScene ("Scene1");
            break;
            case "BttnInfo":
            SceneManager.LoadScene ("Scene2");
            break;
            case "BttnPf":
            SceneManager.LoadScene ("Scene3");
            break;
            case "BttnModel3D":
            SceneManager.LoadScene ("Scene4");
            break;
        }
    }
}
