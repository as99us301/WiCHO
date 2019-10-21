using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H2OCreate : MonoBehaviour {
    public GameObject H_obj;
    public GameObject H2_obj;
    public GameObject O_obj;
    public GameObject Newthing;
    public GameObject Newthing2;
    public GameObject Instantiate_Position;
    public GameObject patentsPrefeb;
    public GameObject Botton1;
    public GameObject Botton2;
    private bool ColWith1 = false;
    private bool ColWith2 = false;

    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "H")
        {
            ColWith1 = true;
        } else if (collision.gameObject.layer == LayerMask.NameToLayer("Num3")) {
            ColWith2 = true;
        }


        if (ColWith1 && ColWith2)
        {
            H_obj.SetActive(false);
            H2_obj.SetActive(false);
            O_obj.SetActive(false);
            Botton1.SetActive(true);
            Botton2.SetActive(true);
            GameObject H2O = Instantiate(Newthing, Instantiate_Position.transform.position, Instantiate_Position.transform.rotation);
            H2O.transform.parent = patentsPrefeb.transform;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "H")
        {
            ColWith1 = false;
            H_obj.SetActive(true);
            H2_obj.SetActive(true);
            O_obj.SetActive(true);
            Botton1.SetActive(false);
            Botton2.SetActive(false);
            Destroy(GameObject.Find("H2O_Prefeb(Clone)"));
            Destroy(GameObject.Find("water(Clone)"));
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("Num3"))
        {
            ColWith2 = false;
            H_obj.SetActive(true);
            H2_obj.SetActive(true);
            O_obj.SetActive(true);
            Botton1.SetActive(false);
            Botton2.SetActive(false);
            Destroy(GameObject.Find("H2O_Prefeb(Clone)"));
            Destroy(GameObject.Find("water(Clone)"));
        }
    }

    public void button1Click()
    {
        Destroy(GameObject.Find("water(Clone)"));
        Destroy(GameObject.Find("H2O_Prefeb(Clone)"));
        GameObject H2O = Instantiate(Newthing, Instantiate_Position.transform.position, Instantiate_Position.transform.rotation);
        H2O.transform.parent = patentsPrefeb.transform;
    }

    public void button2Click()
    {
        Destroy(GameObject.Find("water(Clone)"));
        Destroy(GameObject.Find("H2O_Prefeb(Clone)"));
        GameObject H2O2 = Instantiate(Newthing2, Instantiate_Position.transform.position, Newthing2.transform.rotation);
        H2O2.transform.parent = patentsPrefeb.transform;
    }

}
