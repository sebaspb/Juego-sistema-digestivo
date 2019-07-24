using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animate : MonoBehaviour
{

    Animator RoverM;
    //Ejemplo para detener animación
    //Animation Rv;

    //Animator BocaMo;

    float counter1 = 0;

    public GameObject ContinueButton;
    
    private Animation animations;

    public GameObject Button4;

    public Button Button20;

    public Button Button30;

    public Button Button34;

    bool actC = false;

    // Start is called before the first frame update
    void Start()
    {
        animations = GetComponent<Animation>();
        RoverM = GetComponent<Animator>();
        //BocaMo = GetComponent<Animator>();
        

             
    }

    // Update is called once per frame
    void Update()
    {

        //if (this.RoverM.GetCurrentAnimatorStateInfo(0).IsName("RoverMovement 0"))
        //{

            
                
           ///Debug.Log("Hello");
           //Ejemplo para detener animación
           //Rv.Stop();
                
        //}
        

       if (counter1 >= 34)
       {
                
            ContinueButton.SetActive(true);
            Debug.Log("Finished");

       }

        //Debug.Log(counter1);

    } 

    public void StartAnima()
    {

        RoverM.SetTrigger("Started");
        //BocaMo.SetTrigger("Started");
        
           
    }

    public void AnimBoton1()
    {

        DeactivateButtons();

        for (int count = 1; count <= 4; count++)
        {
            
            actC = true;
            animations.PlayQueued("Boca Unity");
            counter1 += 1.334f;
            Debug.Log(counter1);
        }

        if (actC == true)
        {

            Debug.Log("Hola");
            StartCoroutine(ActivateButtons(4));

        }


    }

    public void AnimBoton2()
    {

        DeactivateButtons();
        for (int count = 1; count <= 20; count++)
        {

            animations.PlayQueued("Boca Unity");
            counter1 += 1.0526f;
            //StartCoroutine(ActivateButtons(20f));
        }

    }

    public void AnimBoton3()
    {

        DeactivateButtons();
        for (int count = 1; count <= 30; count++)
        {

            animations.PlayQueued("Boca Unity");
            counter1 += 1.03448f;
            //StartCoroutine(ActivateButtons(30f));
        }

    }

    public void AnimBoton4()
    {

        DeactivateButtons();
        for (int count = 1; count <= 34; count++)
        {
            animations.PlayQueued("Boca Unity");
            counter1 += 1.03130f;
            //StartCoroutine(ActivateButtons(34f));

        }
    }

    void DeactivateButtons()
    {

        Button4.SetActive(false);
        Button20.interactable = false;
        Button30.interactable = false;
        Button34.interactable = false;

    }

    IEnumerator ActivateButtons(float time)
    {


            Button4.SetActive(true);
            Button20.interactable = true;
            Button30.interactable = true;
            Button34.interactable = true;
            yield return new WaitForSeconds(time);

        
    }
}
