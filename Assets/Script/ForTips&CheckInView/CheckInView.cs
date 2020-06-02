using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckInView : MonoBehaviour
{
    public bool ifInScene = true;
    private GameObject checkImage;

    void Start()
    {
        checkImage = GameObject.Find("checkImage");
    }

    void OnBecameVisible()
    {
        ifInScene = true;
        Debug.Log("Show");
        checkImage.SetActive(false);
    }
    void OnBecameInvisible()
    {
        ifInScene = false;
        Debug.Log("Lost");
        checkImage.SetActive(true);
    }

}
