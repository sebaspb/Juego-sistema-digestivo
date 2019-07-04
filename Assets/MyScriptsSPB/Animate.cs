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
    
    private Animation animation;

    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animation>();
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
        

        if(counter1 == 40 )
        {

            counter1 += 1;
        
        }

        else if (counter1 >= 41)
        {
                
            ContinueButton.SetActive(true);
            Debug.Log("Finished");

        }    

    } 

    public void StartAnima()
    {

        RoverM.SetTrigger("Started");
        //BocaMo.SetTrigger("Started");
        
           
    }

    public void AnimBoton1()
    {

        
        //if(counter1 <= 5)
        //{
        for (int count = 1; count <= 4; count++)
        {
            animation.PlayQueued("test");
        }

        //BocaMo.SetTrigger("Continue");
        //if(BocaMo.SetTrigger("Continue"))
        //{




        //}

        //}

        //else if(counter1 == 6)
    

        
    }

    public void AnimBoton2()
    {

        for (int count = 1; count <= 20; count++)
        {
            animation.PlayQueued("test");
        }

    }

    public void AnimBoton3()
    {

        for (int count = 1; count <= 30; count++)
        {
            animation.PlayQueued("test");
        }

    }

    public void AnimBoton4()
    {

        for (int count = 1; count <= 35; count++)
        {
            animation.PlayQueued("test");
        }
    }

    //public IEnumerator boca (float time)
    //{

        //yield return new WaitForSeconds(time);
        //BocaMo.SetBool("control", false);

    //}
}
