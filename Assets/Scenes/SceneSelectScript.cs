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
            SceneManager.LoadScene ("Informacion");
            break;
            case "BttnInfo":
            SceneManager.LoadScene ("Datos");
            break;
            case "BttnPf":
            SceneManager.LoadScene ("Preguntas");
            break;
            case "BttnModel3D":
            SceneManager.LoadScene ("Modelo3D");
            break;
            case "LavLG":
            SceneManager.LoadScene ("Datos1");
            break;
            case "LavSamsung":
            SceneManager.LoadScene ("Datos1");
            break;
            case "LavMabe":
            SceneManager.LoadScene ("Datos1");
            break;
            case "B1":
            SceneManager.LoadScene ("Datos2");
            break;
            case "B2":
            SceneManager.LoadScene ("Datos3");
            break;
            case "Bienvenidos":
            SceneManager.LoadScene ("Start");
            break;
            case "Info":
            SceneManager.LoadScene ("Informacion");
            break;
            case "Dat":
            SceneManager.LoadScene ("Datos");
            break;
            case "Faq":
            SceneManager.LoadScene ("Preguntas");
            break;
        }
    }
}
