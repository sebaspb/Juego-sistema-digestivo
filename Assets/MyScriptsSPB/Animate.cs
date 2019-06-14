using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{

    Animator RoverM;
   

    // Start is called before the first frame update
    void Start()
    {
           RoverM = GetComponent<Animator>();
       
        
    }

    // Update is called once per frame
    void Update()
    {

        if (this.RoverM.GetCurrentAnimatorStateInfo(0).IsName("RoverMovement 0"))
        {

            Debug.Log("Hello");
          
        }



    }

    public void StartAnima()
    {

        RoverM.SetTrigger("Started");
        
        
    }
}
