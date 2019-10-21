using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COCreate : MonoBehaviour {
    public GameObject Cobj;
    public GameObject Oobj;
    public GameObject Newthing;
    public GameObject Instantiate_Position;
    public GameObject patentsPrefeb;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "O")
        {
            Cobj.SetActive(false);
            Oobj.SetActive(false);
            GameObject CO = Instantiate(Newthing, Instantiate_Position.transform.position, Instantiate_Position.transform.rotation);
            CO.transform.parent = patentsPrefeb.transform;
        }
        else if (collision.gameObject.tag == "C")
        {
            //Cobj.SetActive(false);
            //Oobj.SetActive(false);
            Destroy(Cobj);
            GameObject CO = Instantiate(Newthing, Instantiate_Position.transform.position, Instantiate_Position.transform.rotation);
            CO.transform.parent = patentsPrefeb.transform;
        }

    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "O")
        {
            Destroy(GameObject.Find("CO_test(Clone)"));
            Cobj.SetActive(true);
            Oobj.SetActive(true);
        }
        else if (collision.gameObject.tag == "C")
        {
            Destroy(GameObject.Find("CO_test(Clone)"));
            Cobj.SetActive(true);
            Oobj.SetActive(true);
        }

    }
}
