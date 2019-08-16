using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPanel : MonoBehaviour
{
    public GameObject PanelAlim;
    public GameObject PanelObj;
    public GameObject ImagenCon;
    public GameObject ImagenAdv;

    private Animator AlimAnim;
    private Animator ObjAnim;
    private Animator ConAnim;
    private Animator AdvAnim;

    void Awake()
    {
        AlimAnim = PanelAlim.GetComponent<Animator>();
        ObjAnim = PanelObj.GetComponent<Animator>();
        ConAnim = ImagenCon.GetComponent<Animator>();
        AdvAnim = ImagenAdv.GetComponent<Animator>();
    }

    public void SettingsOne()
    {
        AlimAnim.SetBool("Open", true);
        ObjAnim.SetBool("Close", true);
        ObjAnim.SetBool("Open", false);
    }

    public void SettingsTwo()
    {
        ObjAnim.SetBool("Open", true);
        AlimAnim.SetBool("Close", true);
        AlimAnim.SetBool("Open", false);
    }

    public void SettingsThree()
    {
        ConAnim.SetBool("Open", true);
        AdvAnim.SetBool("Close", true);
        AdvAnim.SetBool("Open", false);
        ObjAnim.SetBool("Close", true);
        ObjAnim.SetBool("Open", false);
        AlimAnim.SetBool("Close", true);
        AlimAnim.SetBool("Open", false);
    }

    public void SettingsFour()
    {
        AdvAnim.SetBool("Open", true);
        ConAnim.SetBool("Close", true);
        ConAnim.SetBool("Open", false);
        ObjAnim.SetBool("Close", true);
        ObjAnim.SetBool("Open", false);
        AlimAnim.SetBool("Close", true);
        AlimAnim.SetBool("Open", false);
    }

    public void SettingsFive()
    {
        ConAnim.SetBool("Close", true);
        ConAnim.SetBool("Open", false);
        AdvAnim.SetBool("Close", true);
        AdvAnim.SetBool("Open", false);
    }
}
