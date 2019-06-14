using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneGameManager : MonoBehaviour
{

    public void CergarScena(string nombreScene)
    {
        SceneManager.LoadScene(nombreScene);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
