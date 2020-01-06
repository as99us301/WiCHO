using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CO2Create : MonoBehaviour
{
    
    public GameObject Newthing;
    public GameObject Newthing2;
    public GameObject Newthing3;
    public GameObject introd; //化合物簡介
    public GameObject Instantiate_Pos1;
    public GameObject Instantiate_Pos2;
    public GameObject patentsPrefeb;
    private bool ColWith1 = false;
    private bool ColWith2 = false;


    public GameObject[] ElementArray;

    public GameObject Ccanvas, Ocanvas;

    private GameObject checkImage;

    void Start()
    {
        checkImage = GameObject.Find("checkImage");
        ElementArray = GameObject.FindGameObjectsWithTag("Element");
    }


    void OnCollisionEnter(Collision collision) //當碰撞開始後
    {
        if (collision.gameObject.tag == "C")
        {
            ColWith1 = true;
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("Num3"))
        {
            ColWith2 = true;
        }

        if (ColWith1 && ColWith2)
        {
            checkImage.SetActive(false);
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(false);
            }
            CloseCanvas();
            GameObject CO2 = Instantiate(Newthing, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
            CO2.transform.parent = patentsPrefeb.transform;
        }

    }

    void OnCollisionStay(Collision collision) //碰撞進行中
    {
        if (ColWith1 && ColWith2)
        {
           /*ButtonCanvas.SetActive(true);
            Botton1.SetActive(true);
            Botton2.SetActive(true);
            Botton3.SetActive(true);
            Botton4.SetActive(true);
            Botton5.SetActive(true);*/
        }
    }

    void OnCollisionExit(Collision collision) //當碰撞結束後
    {
        if (collision.gameObject.tag == "C")
        {
            ColWith1 = false;
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(true);
            }
            /*ButtonCanvas.SetActive(false);
            Botton1.SetActive(false);
            Botton2.SetActive(false);
            Botton3.SetActive(false);
            Botton4.SetActive(false);
            Botton5.SetActive(false); */
            CleanObj(); 
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("Num3"))
        {
            ColWith2 = false;
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(true);
            }
            /*ButtonCanvas.SetActive(false);
            Botton1.SetActive(false);
            Botton2.SetActive(false);
            Botton3.SetActive(false);
            Botton4.SetActive(false);
            Botton5.SetActive(false); */
            CleanObj();
        }
    }

    public void button1Click() //分子結構按鈕
    {
        //CleanObj();
        //introd.SetActive(false);
        GameObject CO2 = Instantiate(Newthing, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        CO2.transform.parent = patentsPrefeb.transform;
    }

    /*
    public void button2Click() //液體按鈕
    {
        CleanObj();
        introd.SetActive(false);
        GameObject H2O2 = Instantiate(Newthing2, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        H2O2.transform.parent = patentsPrefeb.transform;
    }

    public void button3Click() //氣體按鈕
    {
        CleanObj();
        introd.SetActive(false);
        GameObject kettle = Instantiate(Newthing3, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        kettle.transform.parent = patentsPrefeb.transform;
        GameObject furnace2 = Instantiate(furnace, Instantiate_Pos2.transform.position, Instantiate_Pos2.transform.rotation);
        furnace2.transform.parent = patentsPrefeb.transform;
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
    }*/

    public void CleanObj() //清理生成出來的物件
    {        
        Destroy(GameObject.Find("CO2_Prefeb(Clone)"));
    }
    public void CloseCanvas()
    {
        Ccanvas.SetActive(false);
        Ocanvas.SetActive(false);
    } 
}
