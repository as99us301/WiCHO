using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaClCreate : MonoBehaviour
{
    public GameObject CaCl;
    public GameObject introd; //化合物簡介
    public GameObject Athing;
    public GameObject Instantiate_Pos1;
    public GameObject patentsPrefeb;
    public GameObject ButtonCanvas;
    public bool CaClDone;
    public GameObject Cacanvas, Clcanvas;
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
            CaClDone = true;
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("ClLayer"))
        {
            CaClDone = true;
        }

        if (CaClDone)
        {
            CloseCanvas();
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(false);
            }
            checkImage.SetActive(false);
            ButtonCanvas.SetActive(true);
            GameObject CaCl1 = Instantiate(CaCl, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
            CaCl1.transform.parent = patentsPrefeb.transform;
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
            CaClDone = false;
            ButtonCanvas.SetActive(false);
            CleanObj();
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(true);
            }
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("ClLayer"))
        {
            CaClDone = false;
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
        GameObject CaCl0 = Instantiate(CaCl, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        CaCl0.transform.parent = patentsPrefeb.transform;
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
        GameObject ATHING1 = Instantiate(Athing, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        ATHING1.transform.parent = patentsPrefeb.transform;
        introd.SetActive(false);
    }

    public void button5Click() //簡介按鈕
    {
        CleanObj();
        introd.SetActive(true);
    }

    public void CleanObj() //清理生成出來的物件
    {
        Destroy(GameObject.Find("CaCl_Prefeb(Clone)"));
        Destroy(GameObject.Find("Dehumidification(Clone)"));
    }

    public void CloseCanvas()
    {
        Cacanvas.SetActive(false);
        Clcanvas.SetActive(false);
    }
}
