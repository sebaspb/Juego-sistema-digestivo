using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;


public class VideoIntro : MonoBehaviour
{

    public RawImage image;
    public VideoPlayer video;

    void Start()
    {
        StartCoroutine(TimeScene());
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
    IEnumerator TimeScene()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(1);
        StartCoroutine(playVideo());
    }
}
