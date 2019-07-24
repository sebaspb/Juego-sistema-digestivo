using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelesObjects : MonoBehaviour
{
    public GameObject[] PanelPrefab;

    int PanelLength;

    readonly WaitForSeconds delay = new WaitForSeconds(2);

    void Start()
    {
        if (PanelPrefab != null && PanelPrefab.Length != 0)
        {
            PanelLength = PanelPrefab.Length;
             StartCoroutine(PanelActive(3f));
        }
    }

    private int index;

    IEnumerator PanelActive(float time)
    {
        while(index < PanelLength)
        {
            yield return null;
            PanelPrefab[index].SetActive(true);
            yield return delay;
            index++;
        }
        StopAllCoroutines();
    }
}
