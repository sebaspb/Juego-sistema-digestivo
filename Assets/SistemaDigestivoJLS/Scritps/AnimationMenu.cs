using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class AnimationMenu : MonoBehaviour
{
    public RawImage image;
    public VideoPlayer video; 

    void Start()
    {
        StartCoroutine(playVideo());
    }

    IEnumerator playVideo()
    {
        video.Prepare();
        WaitForSeconds WFS = new WaitForSeconds(0.15f);
        while (!video.isPrepared)
        {
            yield return WFS;
            break;
        }
        image.texture = video.texture;
        video.Play();
    }

}
