using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animate : MonoBehaviour
{

    Animator RoverM;
    //Ejemplo para detener animación
    //Animation Rv;

    Animator BocaMo;

    float counter1 = 0;

    //public Animation BocaM;

    // Start is called before the first frame update
    void Start()
    {

        RoverM = GetComponent<Animator>();
        BocaMo = GetComponent<Animator>();
        ;
        

          
    }

    // Update is called once per frame
    void Update()
    {

        if (this.RoverM.GetCurrentAnimatorStateInfo(0).IsName("RoverMovement 0"))
        {

            
                
           Debug.Log("Hello");
           //Ejemplo para detener animación
           //Rv.Stop();
                
        }
      
    } 

    public void StartAnima()
    {

        RoverM.SetTrigger("Started");
        BocaMo.SetTrigger("Started");
        //BocaM.Play();
           
    }

    public void AnimBoton1()
    {

        counter1 += 1;
        if(counter1 < 5)
        {

            BocaMo.SetTrigger("Started");

        }
    }

    public void AnimBoton2()
    {

        counter1 += 1;
        if(counter1 < 20)
        {

            BocaMo.SetTrigger("Started");

        }

    }

    public void AnimBoton3()
    {

        counter1 += 1;
        if(counter1 < 30)
        {

            BocaMo.SetTrigger("Started");

        }

    }

    public void AnimBoton4()
    {

        counter1 += 1;
        if(counter1 < 40)
        {

            BocaMo.SetTrigger("Started");

        }

        else
        {

            Debug.Log("Finished");

        }

    }

 }
