using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputTouch : MonoBehaviour
{

    public string nameS;

    private Animation animations;

    void Start()
    {

        animations = GetComponent<Animation>();

    }

    void Update()
    {
                   
        if (Input.touchCount > 0)
        {

            if (!animations.Play("Esofago"))
            {
                
                Debug.Log(Input.GetTouch(0).position);
                SceneManager.LoadScene(nameS);
                
            }
        }
    }
}