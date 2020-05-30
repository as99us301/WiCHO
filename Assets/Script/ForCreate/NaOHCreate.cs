using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaOHCreate : MonoBehaviour
{
    public GameObject NaOH;
    public GameObject introd; //化合物簡介
    public GameObject Instantiate_Pos1;
    public GameObject patentsPrefeb;
    public GameObject ButtonCanvas;
    public GameObject soap;
    public bool NaOHDone;
    public bool ColWithH = false;
    public bool ColWithNa = false;
    public GameObject Hcanvas, Ocanvas, Nacanvas;
    public GameObject[] ElementArray;
    private GameObject checkImage;

    void Start()
    {
       
    checkImage = GameObject.Find("checkImage");
        ElementArray = GameObject.FindGameObjectsWithTag("Element");
    }

    void OnCollisionEnter(Collision collision) //當碰撞開始後
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("HLayer"))
        {
            ColWithH = true;
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("NaLayer"))
        {
            ColWithNa = true;
        }

        if (ColWithNa && ColWithH) 
        {
            NaOHDone = true;        
        }


        if (NaOHDone)
        {
            Debug.Log("nAOHdone");
            CloseCanvas();
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(false);
            }
            checkImage.SetActive(false);
            ButtonCanvas.SetActive(true);
            GameObject Naoh1 = Instantiate(NaOH, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
            Naoh1.transform.parent = patentsPrefeb.transform;
        }
    }

    void OnCollisionStay(Collision collision) //碰撞進行中
    {
       return;
    }

    void OnCollisionExit(Collision collision) //當碰撞結束後
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("HLayer"))
        {
            ColWithH = false;
            ColWithNa = false;
            NaOHDone = false;
            ButtonCanvas.SetActive(false);
            CleanObj();
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(true);
            }
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("NaLayer"))
        {
            ColWithH = false;
            ColWithNa = false;
            NaOHDone = false;
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
        GameObject naoh0 = Instantiate(NaOH, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        naoh0.transform.parent = patentsPrefeb.transform;
    }


    public void button4Click() //固體按鈕
    {
        CleanObj();
        GameObject ATHING1 = Instantiate(soap, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
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
        Destroy(GameObject.Find("NaOH_Prefeb(Clone)"));
        Destroy(GameObject.Find("soap(Clone)"));
    }

    public void CloseCanvas()
    {
        Hcanvas.SetActive(false);
        Ocanvas.SetActive(false);
        Nacanvas.SetActive(false);
    }
}
