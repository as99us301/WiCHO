using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HClCreate : MonoBehaviour
{
    public GameObject HCl;
    public GameObject introd; //化合物簡介
    public GameObject Instantiate_Pos1;
    public GameObject patentsPrefeb;
    public GameObject ButtonCanvas;
    public bool HClDone;
    public GameObject Hcanvas, Clcanvas;
    public GameObject[] ElementArray;
    private GameObject checkImage;

    void Start()
    {
        checkImage = GameObject.Find("checkImage");
        ElementArray = GameObject.FindGameObjectsWithTag("Element");
    }

    void OnCollisionEnter(Collision collision) //當碰撞開始後
    {
        if (collision.gameObject.tag == "Cl")
        {
            HClDone = true;
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("ClLayer"))
        {
            HClDone = true;
        }

        if (HClDone)
        {
            CloseCanvas();
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(false);
            }
            checkImage.SetActive(false);
            ButtonCanvas.SetActive(true);
            GameObject HCl1 = Instantiate(HCl, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
            HCl1.transform.parent = patentsPrefeb.transform;
        }
    }

    void OnCollisionStay(Collision collision) //碰撞進行中
    {
        return;
    }

    void OnCollisionExit(Collision collision) //當碰撞結束後
    {
        if (collision.gameObject.tag == "Cl")
        {
            HClDone = false;
            ButtonCanvas.SetActive(false);
            CleanObj();
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(true);
            }
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("ClLayer"))
        {
            HClDone = false;
            ButtonCanvas.SetActive(false);
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
        GameObject HCl0 = Instantiate(HCl, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        HCl0.transform.parent = patentsPrefeb.transform;
    }

    public void button2Click() //液體按鈕
    {
        CleanObj();
        introd.SetActive(false);
    }

    public void button3Click() //氣體按鈕
    {
        CleanObj();
        introd.SetActive(false);
    }

    public void button4Click() //固體按鈕
    {
        CleanObj();
        //GameObject ATHING1 = Instantiate(thing, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        //ATHING1.transform.parent = patentsPrefeb.transform;
        introd.SetActive(false);
    }

    public void button5Click() //簡介按鈕
    {
        CleanObj();
        introd.SetActive(true);
    }

    public void CleanObj() //清理生成出來的物件
    {
        Destroy(GameObject.Find("HCl_Prefeb(Clone)"));
    }

    public void CloseCanvas()
    {
        Hcanvas.SetActive(false);
        Clcanvas.SetActive(false);
    }
}
