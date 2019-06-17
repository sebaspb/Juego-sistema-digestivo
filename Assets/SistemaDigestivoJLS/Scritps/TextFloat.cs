using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFloat : MonoBehaviour
{
    public float TextAparece ;
    public bool Texto = false;

    private void Update()
    {
        

        TextAparece -= Time.deltaTime;
            if (TextAparece <= 0)
            {
                gameObject.SetActive(false);

            }



        transform.position = new Vector3(transform.parent.position.x + 5,
        transform.parent.position.y + 2, transform.parent.position.z);

        StartCoroutine(TimeBefore(3));

    }

    IEnumerator TimeBefore(float Time)
    {
        if(gameObject.activeSelf && Texto == false)
        {

            gameObject.SetActive(true);

        }
        yield return new WaitForSeconds(Time);
    }

}
