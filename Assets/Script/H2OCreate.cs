using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H2OCreate : MonoBehaviour {
    public GameObject H_obj;
    public GameObject H2_obj;
    public GameObject O_obj;
    public GameObject Newthing;
    public GameObject Newthing2;
    public GameObject Newthing3;
    public ParticleSystem effect;
    public ParticleSystem waterEffect;
    public GameObject fireEffect;
    public GameObject Instantiate_Pos1;
    public GameObject Instantiate_Pos2;
    public GameObject patentsPrefeb;
    public GameObject Botton1;
    public GameObject Botton2;
    public GameObject Botton3;
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
            Botton3.SetActive(true);
            effect.Play();
            GameObject H2O = Instantiate(Newthing, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
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
            Botton3.SetActive(false);
            effect.Stop();
            Destroy(GameObject.Find("H2O_Prefeb(Clone)"));
            Destroy(GameObject.Find("water(Clone)"));
            Destroy(GameObject.Find("kettle(Clone)"));
            Destroy(GameObject.Find("fire(Clone)"));
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("Num3"))
        {
            ColWith2 = false;
            H_obj.SetActive(true);
            H2_obj.SetActive(true);
            O_obj.SetActive(true);
            Botton1.SetActive(false);
            Botton2.SetActive(false);
            Botton3.SetActive(false);
            effect.Stop();
            Destroy(GameObject.Find("H2O_Prefeb(Clone)"));
            Destroy(GameObject.Find("water(Clone)"));
            Destroy(GameObject.Find("kettle(Clone)"));
            Destroy(GameObject.Find("fire(Clone)"));
        }
    }

    public void button1Click()
    {
        Destroy(GameObject.Find("water(Clone)"));
        Destroy(GameObject.Find("H2O_Prefeb(Clone)"));
        Destroy(GameObject.Find("kettle(Clone)"));
        Destroy(GameObject.Find("fire(Clone)"));
        GameObject H2O = Instantiate(Newthing, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        H2O.transform.parent = patentsPrefeb.transform;
    }

    public void button2Click()
    {
        Destroy(GameObject.Find("water(Clone)"));
        Destroy(GameObject.Find("H2O_Prefeb(Clone)"));
        Destroy(GameObject.Find("kettle(Clone)"));
        Destroy(GameObject.Find("fire(Clone)"));
        GameObject H2O2 = Instantiate(Newthing2, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        H2O2.transform.parent = patentsPrefeb.transform;
    }

    public void button3Click()
    {
        Destroy(GameObject.Find("water(Clone)"));
        Destroy(GameObject.Find("H2O_Prefeb(Clone)"));
        GameObject kettle = Instantiate(Newthing3, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        kettle.transform.parent = patentsPrefeb.transform;
        waterEffect.Stop();
        GameObject fire = Instantiate(fireEffect, Instantiate_Pos2.transform.position, Instantiate_Pos2.transform.rotation);
        fire.transform.parent = patentsPrefeb.transform;
    }

}
