using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public string TagMusica = "Music";
    internal float InstanceTime = 0;

    void Awake()
    {
        //Find all the music objects in the scene
        GameObject[] ObjetosMusica = GameObject.FindGameObjectsWithTag(TagMusica);

        //Keep only the music object which has been in the game for more than 0 seconds
        if (ObjetosMusica.Length > 1)
        {
            foreach (var ObjetoMusica in ObjetosMusica)
            {
                if (ObjetoMusica.GetComponent<SoundManager>().InstanceTime <= 0) Destroy(gameObject);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

}
