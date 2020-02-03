using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H2OCreate : MonoBehaviour {
    public GameObject H2O;
    public GameObject H2O2;
    public GameObject H2O3;
    public GameObject introd; //化合物簡介
    public GameObject ice;
    public GameObject Instantiate_Pos1;
    public GameObject patentsPrefeb;
    public GameObject ButtonCanvas;
    public GameObject Botton1;
    public GameObject Botton2;
    public GameObject Botton3;
    public GameObject Botton4;
    public GameObject Botton5;
    public bool ColWith1H;
    public bool ColWith2H;
    public GameObject Hcanvas, Ocanvas;
    public GameObject[] ElementArray;
    private GameObject checkImage;
    void Start()
    {
        checkImage = GameObject.Find("checkImage");
        ElementArray = GameObject.FindGameObjectsWithTag("Element");
    }
    void OnCollisionEnter(Collision collision) //當碰撞開始後
    {
        if (collision.gameObject.tag == "H")
        {
            ColWith1H = true;
        } else if (collision.gameObject.layer == LayerMask.NameToLayer("HLayer"))
        {
            ColWith2H = true;
        }

        if (ColWith1H && ColWith2H)
        {
            CloseCanvas();
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(false);
            }
            checkImage.SetActive(false);
            GameObject H2O1 = Instantiate(H2O, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
            H2O1.transform.parent = patentsPrefeb.transform;
        }
    }

    void OnCollisionStay(Collision collision) //碰撞進行中
    {
        if (ColWith1H && ColWith2H)
        {
            ButtonCanvas.SetActive(true);
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
            ColWith1H = false;
            ColWith2H = false;
            ButtonCanvas.SetActive(false);
            Botton1.SetActive(false);
            Botton2.SetActive(false);
            Botton3.SetActive(false);
            Botton4.SetActive(false);
            Botton5.SetActive(false);
            CleanObj();
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(true);
            }
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("HLayer"))
        {
            ColWith1H = false;
            ColWith2H = false;
            ButtonCanvas.SetActive(false);
            Botton1.SetActive(false);
            Botton2.SetActive(false);
            Botton3.SetActive(false);
            Botton4.SetActive(false);
            Botton5.SetActive(false);
            CleanObj();
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(true);
            }
        }
    }

    public void button1Click() //分子結構按鈕
    {
        CleanObj();
        introd.SetActive(false);
        GameObject H2O0 = Instantiate(H2O, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        H2O0.transform.parent = patentsPrefeb.transform;
    }

    public void button2Click() //液體按鈕
    {      
        CleanObj();
        introd.SetActive(false);
        GameObject H2O02 = Instantiate(H2O2, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        H2O02.transform.parent = patentsPrefeb.transform;
    }

    public void button3Click() //氣體按鈕
    {
        CleanObj();
        introd.SetActive(false);
        GameObject kettle = Instantiate(H2O3, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        kettle.transform.parent = patentsPrefeb.transform;
    }

    public void button4Click() //固體按鈕
    {
        CleanObj();
        introd.SetActive(false);
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

    public void CloseCanvas()
    {
        Hcanvas.SetActive(false);
        Ocanvas.SetActive(false);
    }
}
