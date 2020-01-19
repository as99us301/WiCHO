using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementButton : MonoBehaviour
{
    public GameObject pos;
    public GameObject[] ElementBall;

    private void Start()
    {
       ElementBall = GameObject.FindGameObjectsWithTag("Element");
       for (int i = 0; i <  ElementBall.Length; i++)
       {
            ElementBall[i].gameObject.SetActive(false);
       }
    }

    public void cleanObj() 
    {
        for (int i = 0; i < ElementBall.Length; i++)
        {
            ElementBall[i].gameObject.SetActive(false);
        }
    }

    public void HClick()
    {
        cleanObj();
        Instantiate(ElementBall[0], pos.transform.position, pos.transform.rotation);
    }
    public void HeClick()
    {
        cleanObj();
        Instantiate(ElementBall[1], pos.transform.position, pos.transform.rotation);
    }
    public void LiClick()
    {
        cleanObj();
        Instantiate(ElementBall[2], pos.transform.position, pos.transform.rotation);
    }
    public void BeClick()
    {
        cleanObj();
        Instantiate(ElementBall[3], pos.transform.position, pos.transform.rotation);
    }
    public void BClick()
    {
        cleanObj();
        Instantiate(ElementBall[4], pos.transform.position, pos.transform.rotation);
    }
    public void CClick()
    {
        cleanObj();
        Instantiate(ElementBall[5], pos.transform.position, pos.transform.rotation);
    }
    public void NClick()
    {
        cleanObj();
        Instantiate(ElementBall[6], pos.transform.position, pos.transform.rotation);
    }
    public void OClick()
    {
        cleanObj();
        Instantiate(ElementBall[7], pos.transform.position, pos.transform.rotation);
    }
    public void FClick()
    {
        cleanObj();
        Instantiate(ElementBall[8], pos.transform.position, pos.transform.rotation);
    }
    public void NeClick()
    {
        cleanObj();
        Instantiate(ElementBall[9], pos.transform.position, pos.transform.rotation);
    }

}
