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

            Debug.Log(Input.GetTouch(0).position);
            SceneManager.LoadScene(nameS);
                    
        }

    }

    public void IniciarAnimaciónEs()
    {

        animations.PlayQueued("Esofago");
        new WaitForSeconds(4f);

        if(!animations.PlayQueued("Esofago"))
        {

            Debug.Log("Hello");
            
        }

    }
}