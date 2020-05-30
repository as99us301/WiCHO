using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstOHBox : MonoBehaviour
{
    public GameObject newBox;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "O")      
        {
            if (collision.gameObject.GetComponent<H2OCreate>().H2OComplete == true) 
            {
                newBox.SetActive(false);
            }
            else 
            {
                newBox.SetActive(true);
            }
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "O")
        {
            newBox.SetActive(false);
        }
    }
}
