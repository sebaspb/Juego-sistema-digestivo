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

    public Button Button4;

    public GameObject Button20;

    public GameObject Button30;

    public GameObject Button34;

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

        Debug.Log(counter1);

    } 

    public void StartAnima()
    {

        RoverM.SetTrigger("Started");
        //BocaMo.SetTrigger("Started");
        
           
    }

    public void AnimBoton1()
    {

        
        
        for (int count = 1; count <= 3; count++)
        {
            
            animations.PlayQueued("test");
            counter1 += 1.334f;
            //Button4.interactable = !Button4.interactable;          
        }
    }

    public void AnimBoton2()
    {

        for (int count = 1; count <= 20; count++)
        {
            
            animations.PlayQueued("test");
            counter1 += 1.0526f;
        }

    }

    public void AnimBoton3()
    {

        for (int count = 1; count <= 29; count++)
        {
            
            animations.PlayQueued("test");
            counter1 += 1.03448f;
        }

    }

    public void AnimBoton4()
    {

        for (int count = 1; count <= 33; count++)
        {
            animations.PlayQueued("test");
            counter1 += 1.03130f;

        }
    }
}
