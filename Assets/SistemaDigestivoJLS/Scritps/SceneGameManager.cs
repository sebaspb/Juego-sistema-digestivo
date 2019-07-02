using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneGameManager : MonoBehaviour
{
    public GameObject PanelSettings;
    public GameObject Open;
    public GameObject Close;
    private Animator menuAnim;

    void Awake()
    {
        menuAnim = PanelSettings.GetComponent<Animator>();
    }

    public void SettingsOne()
    {
        Open.SetActive(true);
        Close.SetActive(false);
        Open.SetActive(false);
        Close.SetActive(true);
        menuAnim.SetBool("Open",true);
        menuAnim.SetBool("Close",false);    
    }

    public void SettingsTwo()
    {
        Open.SetActive(false);
        Close.SetActive(true);
        Open.SetActive(true);
        Close.SetActive(false);
        menuAnim.SetBool("Close", true);
        menuAnim.SetBool("Open",false);
        
    }

    public void CergarScena(string nombreScene)
    {
        SceneManager.LoadScene(nombreScene);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
