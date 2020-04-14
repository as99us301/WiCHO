using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickedtest : MonoBehaviour
{
    public GameObject[] introdImage;
    public GameObject firstimage;
    public GameObject testmanager;
    public int shownum;

    private void Update()
    {
        shownum = testmanager.GetComponent<NumberBridge>().testnum;
    }

    public void click()
    {
        firstimage.SetActive(false);
        introdImage[shownum].SetActive(true);
    }
}
