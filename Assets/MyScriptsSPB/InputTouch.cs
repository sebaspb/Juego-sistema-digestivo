using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTouch : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {

        if (Input.touchCount > 0)
        {

            Debug.Log(Input.GetTouch(0).position);
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(0, 0, 0);

        }
    }
}


