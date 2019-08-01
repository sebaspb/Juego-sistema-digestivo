using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialogo : MonoBehaviour
{
    public TextMeshProUGUI texPlay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public GameObject ButtonScene;
    public GameObject Nube;

    void Start()
    {
        StartCoroutine(TimeText());
    }

    void Update()
    {
        if ( texPlay.text == sentences [index] )
        {
            continueButton.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        Nube.SetActive(false);
        foreach (char letter in sentences[index].ToCharArray())
        {
            texPlay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
            Nube.SetActive(true);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);
        ButtonScene.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            texPlay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            texPlay.text = "";
            continueButton.SetActive(false);
            ButtonScene.SetActive(true);
        }

    }

    public void NextDialago()
    {
        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            texPlay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            texPlay.text = "";
            continueButton.SetActive(false);
            Nube.SetActive(false);
        }

    }

    IEnumerator TimeText()
    {
        yield return new WaitForSeconds(2);
        StartCoroutine(Type());
        Debug.Log("aparesco");
    }
}
