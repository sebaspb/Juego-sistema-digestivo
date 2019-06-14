using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject PrefabText;
    public bool Texto = false;

    private void Start()
    {
        TextLoand();

    }

    public void TextLoand()
    {

        
        GameObject texto = Instantiate(PrefabText);
        texto.transform.position = new Vector3(this.gameObject.transform.position.x + 5,
        this.gameObject.transform.position.y + 2, this.gameObject.transform.position.z);
        texto.transform.SetParent(this.transform);
        Debug.Log("Apesco en la portada Auuuuu");
    }

    IEnumerator TextoAparece(float time)
    {


        yield return new WaitForSeconds(time);

    }

    
}
