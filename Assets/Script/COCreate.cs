using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COCreate : MonoBehaviour {
    public GameObject newobj;
    public GameObject Cobj;
    public GameObject Oobj;
    public GameObject Newthing;
    public GameObject Instantiate_Position;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "O")
        {
            Cobj.SetActive(false);
            Oobj.SetActive(false);
            //newobj.SetActive(true);
            Instantiate(Newthing, Instantiate_Position.transform.position, Instantiate_Position.transform.rotation);
        }
        else if (collision.gameObject.tag == "C")
        {
            Cobj.SetActive(false);
            Oobj.SetActive(false);
            //newobj.SetActive(true);
            Instantiate(Newthing, Instantiate_Position.transform.position, Instantiate_Position.transform.rotation);
        }

    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "O")
        {
            Destroy(GameObject.Find("CO_test(Clone)"));
            Cobj.SetActive(true);
            Oobj.SetActive(true);
            //newobj.SetActive(false);
        }
        else if (collision.gameObject.tag == "C")
        {
            Destroy(GameObject.Find("CO_test(Clone)"));
            Cobj.SetActive(true);
            Oobj.SetActive(true);
            //newobj.SetActive(false);
        }

    }
}
