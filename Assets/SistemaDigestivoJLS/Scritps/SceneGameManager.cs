using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneGameManager : MonoBehaviour
{
    public GameObject PanelSettings;
    public GameObject PanelOption;

    public GameObject Open;
    public GameObject Close;
    public GameObject OpOpen;
    public GameObject OpClos;

    private Animator menuAnim;
    private Animator OptionAnim;

    void Awake()
    {
        menuAnim = PanelSettings.GetComponent<Animator>();
        OptionAnim = PanelOption.GetComponent<Animator>();
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

    public void OptionOP()
    {
        OpOpen.SetActive(true);
        OpClos.SetActive(false);
        OpOpen.SetActive(false);
        OpClos.SetActive(true);
        OptionAnim.SetBool("Open",true);
        OptionAnim.SetBool("Close",false);
    }

    public void OptionClo()
    {
        OpOpen.SetActive(false);
        OpClos.SetActive(true);
        OpOpen.SetActive(true);
        OpClos.SetActive(false);
        OptionAnim.SetBool("Close", true);
        OptionAnim.SetBool("Open", false);
    }

    public void CargarScena(string nombreScene)
    {
        SceneManager.LoadScene(nombreScene);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
