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
    public GameObject furnace;
    public GameObject introd;
    public GameObject ice;
    public GameObject Instantiate_Pos1;
    public GameObject Instantiate_Pos2;
    public GameObject patentsPrefeb;
    public GameObject Botton1;
    public GameObject Botton2;
    public GameObject Botton3;
    public GameObject Botton4;
    public GameObject Botton5;
    private bool ColWith1 = false;
    private bool ColWith2 = false;
    private bool NoColWith = true;

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
            NoColWith = false;
            H_obj.SetActive(false);
            H2_obj.SetActive(false);
            O_obj.SetActive(false);
            Botton1.SetActive(true);
            Botton2.SetActive(true);
            Botton3.SetActive(true);
            Botton4.SetActive(true);
            Botton5.SetActive(true);
            GameObject H2O = Instantiate(Newthing, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
            H2O.transform.parent = patentsPrefeb.transform;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "H")
        {
            NoColWith = true;
            ColWith1 = false;
            H_obj.SetActive(true);
            H2_obj.SetActive(true);
            O_obj.SetActive(true);
            Botton1.SetActive(false);
            Botton2.SetActive(false);
            Botton3.SetActive(false);
            Botton4.SetActive(false);
            Botton5.SetActive(false);
            Destroy(GameObject.Find("water(Clone)"));
            Destroy(GameObject.Find("H2O_Prefeb(Clone)"));
            Destroy(GameObject.Find("kettle(Clone)"));
            Destroy(GameObject.Find("fire(Clone)"));
            Destroy(GameObject.Find("furnace(Clone)"));
            Destroy(GameObject.Find("ice(Clone)"));
            introd.SetActive(false);
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("Num3"))
        {
            NoColWith = true;
            ColWith2 = false;
            H_obj.SetActive(true);
            H2_obj.SetActive(true);
            O_obj.SetActive(true);
            Botton1.SetActive(false);
            Botton2.SetActive(false);
            Botton3.SetActive(false);
            Botton4.SetActive(false);
            Botton5.SetActive(false);
            Destroy(GameObject.Find("water(Clone)"));
            Destroy(GameObject.Find("H2O_Prefeb(Clone)"));
            Destroy(GameObject.Find("kettle(Clone)"));
            Destroy(GameObject.Find("fire(Clone)"));
            Destroy(GameObject.Find("furnace(Clone)"));
            Destroy(GameObject.Find("ice(Clone)"));
            introd.SetActive(false);
        }
    }

    public void button1Click()
    {
        Destroy(GameObject.Find("water(Clone)"));
        Destroy(GameObject.Find("H2O_Prefeb(Clone)"));
        Destroy(GameObject.Find("kettle(Clone)"));
        Destroy(GameObject.Find("fire(Clone)"));
        Destroy(GameObject.Find("furnace(Clone)"));
        Destroy(GameObject.Find("ice(Clone)"));
        introd.SetActive(false);
        GameObject H2O = Instantiate(Newthing, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        H2O.transform.parent = patentsPrefeb.transform;
    }

    public void button2Click()
    {
        Destroy(GameObject.Find("water(Clone)"));
        Destroy(GameObject.Find("H2O_Prefeb(Clone)"));
        Destroy(GameObject.Find("kettle(Clone)"));
        Destroy(GameObject.Find("fire(Clone)"));
        Destroy(GameObject.Find("furnace(Clone)"));
        Destroy(GameObject.Find("ice(Clone)"));
        introd.SetActive(false);
        GameObject H2O2 = Instantiate(Newthing2, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        H2O2.transform.parent = patentsPrefeb.transform;
    }

    public void button3Click()
    {
        Destroy(GameObject.Find("water(Clone)"));
        Destroy(GameObject.Find("H2O_Prefeb(Clone)"));
        Destroy(GameObject.Find("kettle(Clone)"));
        Destroy(GameObject.Find("fire(Clone)"));
        Destroy(GameObject.Find("furnace(Clone)"));
        Destroy(GameObject.Find("ice(Clone)"));
        introd.SetActive(false);
        GameObject kettle = Instantiate(Newthing3, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        kettle.transform.parent = patentsPrefeb.transform;
        GameObject furnace2 = Instantiate(furnace, Instantiate_Pos2.transform.position, Instantiate_Pos2.transform.rotation);
        furnace2.transform.parent = patentsPrefeb.transform;
    }

    public void button4Click()
    {
        Destroy(GameObject.Find("water(Clone)"));
        Destroy(GameObject.Find("H2O_Prefeb(Clone)"));
        Destroy(GameObject.Find("kettle(Clone)"));
        Destroy(GameObject.Find("fire(Clone)"));
        Destroy(GameObject.Find("furnace(Clone)"));
        Destroy(GameObject.Find("ice(Clone)"));
        introd.SetActive(false);
        GameObject icee = Instantiate(ice, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        icee.transform.parent = patentsPrefeb.transform;
    }



    public void button5Click()
    {
        Destroy(GameObject.Find("water(Clone)"));
        Destroy(GameObject.Find("H2O_Prefeb(Clone)"));
        Destroy(GameObject.Find("kettle(Clone)"));
        Destroy(GameObject.Find("fire(Clone)"));
        Destroy(GameObject.Find("furnace(Clone)"));
        Destroy(GameObject.Find("ice(Clone)"));
        introd.SetActive(true);
    }

    public void CleanObj()
    {
        Destroy(GameObject.Find("water(Clone)"));
        Destroy(GameObject.Find("H2O_Prefeb(Clone)"));
        Destroy(GameObject.Find("kettle(Clone)"));
        Destroy(GameObject.Find("fire(Clone)"));
        Destroy(GameObject.Find("furnace(Clone)"));
        Destroy(GameObject.Find("ice(Clone)"));
        introd.SetActive(false);
    }
}
