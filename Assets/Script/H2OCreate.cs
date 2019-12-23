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
    public GameObject introd; //化合物簡介
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

     
    void OnCollisionEnter(Collision collision) //當碰撞開始後
    {
        if (collision.gameObject.tag == "H")
        {
            ColWith1 = true;
        } else if (collision.gameObject.layer == LayerMask.NameToLayer("Num3")) {
            ColWith2 = true;
        }

        if (ColWith1 && ColWith2)
        {
            GameObject H2O = Instantiate(Newthing, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
            H2O.transform.parent = patentsPrefeb.transform;
        }

    }

    void OnCollisionStay(Collision collision) //碰撞進行中
    {
        if (ColWith1 && ColWith2)
        {
            H_obj.SetActive(false);
            H2_obj.SetActive(false);
            O_obj.SetActive(false);
            Botton1.SetActive(true);
            Botton2.SetActive(true);
            Botton3.SetActive(true);
            Botton4.SetActive(true);
            Botton5.SetActive(true);            
        }
    }

    void OnCollisionExit(Collision collision) //當碰撞結束後
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
            Botton4.SetActive(false);
            Botton5.SetActive(false);
            CleanObj();
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
            Botton4.SetActive(false);
            Botton5.SetActive(false);
            CleanObj();
        }
    }

    public void button1Click() //分子結構按鈕
    {
        CleanObj();
        GameObject H2O = Instantiate(Newthing, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        H2O.transform.parent = patentsPrefeb.transform;
    }

    public void button2Click() //液體按鈕
    {
        CleanObj();
        GameObject H2O2 = Instantiate(Newthing2, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        H2O2.transform.parent = patentsPrefeb.transform;
    }

    public void button3Click() //氣體按鈕
    {
        CleanObj();
        GameObject kettle = Instantiate(Newthing3, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        kettle.transform.parent = patentsPrefeb.transform;
        GameObject furnace2 = Instantiate(furnace, Instantiate_Pos2.transform.position, Instantiate_Pos2.transform.rotation);
        furnace2.transform.parent = patentsPrefeb.transform;
    }

    public void button4Click() //固體按鈕
    {
        CleanObj();
        GameObject icee = Instantiate(ice, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        icee.transform.parent = patentsPrefeb.transform;
    }
    
    public void button5Click() //簡介按鈕
    {
        CleanObj();
        introd.SetActive(true);
    }

    public void CleanObj() //清理生成出來的物件
    {
        Destroy(GameObject.Find("water(Clone)"));
        Destroy(GameObject.Find("H2O_Prefeb(Clone)"));
        Destroy(GameObject.Find("kettle(Clone)"));
        Destroy(GameObject.Find("fire(Clone)"));
        Destroy(GameObject.Find("furnace(Clone)"));
        Destroy(GameObject.Find("ice(Clone)"));
    }
}
