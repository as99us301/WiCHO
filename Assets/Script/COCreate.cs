using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COCreate : MonoBehaviour {
    public GameObject newobj;
    public GameObject Cobj;
    public GameObject Oobj;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "O")
        {
            Cobj.SetActive(false);
            Oobj.SetActive(false);
            newobj.SetActive(true);
        }
        else if (collision.gameObject.tag == "C")
        {
            Cobj.SetActive(false);
            Oobj.SetActive(false);
            newobj.SetActive(true);
        }

    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "O")
        {
            Cobj.SetActive(true);
            Oobj.SetActive(true);
            newobj.SetActive(false);
        }
        else if (collision.gameObject.tag == "C")
        {
            Cobj.SetActive(true);
            Oobj.SetActive(true);
            newobj.SetActive(false);
        }

    }
}
