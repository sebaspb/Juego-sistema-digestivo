using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputTouch : MonoBehaviour
{

    public string nameS;
    void Start()
    {

    }


    void Update()
    {

        if (Input.touchCount > 0)
        {

            Debug.Log(Input.GetTouch(0).position);
            SceneManager.LoadScene(nameS);
            
        }
    }

   
}


