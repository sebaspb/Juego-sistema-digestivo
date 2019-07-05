using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public string TagMusica = "Music";
    internal float InstanceTime = 0;

    GameObject[] pause;

    public GameObject Sound;

    public GameObject Silence;

    void Awake()
    {
        //Find all the music objects in the scene
        GameObject[] ObjetosMusica = GameObject.FindGameObjectsWithTag(TagMusica);

        
        if (ObjetosMusica.Length > 1)
        {
            foreach (var ObjetoMusica in ObjetosMusica)
            {
                if (ObjetoMusica.GetComponent<SoundManager>().InstanceTime <= 0)
                {

                    //Destroy(gameObject);

                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        pause = GameObject.FindGameObjectsWithTag("pause");
        foreach(GameObject pauseObj in pause)
        {

            pauseObj.SetActive(false);

        }

        Sound.SetActive(false);
        Silence.SetActive(true);

    }

    public void MusicController()
    {
        
        AudioListener.pause = !AudioListener.pause;
        Sound.SetActive(false);
        Silence.SetActive(true);
        if(AudioListener.pause)
        {

            Silence.SetActive(false);
            Sound.SetActive(true);

        }
       
    }
        
}
