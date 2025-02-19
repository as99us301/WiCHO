﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class NaClCreate : MonoBehaviour
{
    public GameObject NaCl;
    public GameObject introd; //化合物簡介
    public GameObject salt;
    public GameObject Instantiate_Pos1;
    public GameObject patentsPrefeb;
    public GameObject ButtonCanvas;
    public bool NaClDone;
    public GameObject Nacanvas, Clcanvas;
    public GameObject[] ElementArray;
    private GameObject checkImage;
    private string puzzleid;

    void Start()
    {
        checkImage = GameObject.Find("checkImage");
        ElementArray = GameObject.FindGameObjectsWithTag("Element");
    }

    void OnCollisionEnter(Collision collision) //當碰撞開始後
    {
        if (collision.gameObject.tag == "Na")
        {
            puzzleid = collision.gameObject.name;
            NaClDone = true;
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("NaLayer"))
        {
            puzzleid = collision.gameObject.name;
            NaClDone = true; 
        }

        if (NaClDone) {
            CloseCanvas();
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(false);
            }
            checkImage.SetActive(false);
            ButtonCanvas.SetActive(true);
            GameObject NaCl1 = Instantiate(NaCl, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
            NaCl1.transform.parent = patentsPrefeb.transform;
        }
    }

    void OnCollisionStay(Collision collision) //碰撞進行中
    {
        return;
    }

    void OnCollisionExit(Collision collision) //當碰撞結束後
    {
        if (collision.gameObject.tag == "Na")
        {
            NaClDone = false;
            ButtonCanvas.SetActive(false);
            CleanObj();
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(true);
            }
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("NaLayer"))
        {
            NaClDone = false;
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
        GameObject NaCl0 = Instantiate(NaCl, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        NaCl0.transform.parent = patentsPrefeb.transform;
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
        GameObject saltt = Instantiate(salt, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        saltt.transform.parent = patentsPrefeb.transform;
        introd.SetActive(false);
    }

    public void button5Click() //簡介按鈕
    {
        CleanObj();
        introd.SetActive(true);
    }

    public void CleanObj() //清理生成出來的物件
    {
        Destroy(GameObject.Find("NaCl_Prefeb(Clone)"));
        Destroy(GameObject.Find("salt(Clone)"));
    }

    public void CloseCanvas()
    {
        Nacanvas.SetActive(false);
        Clcanvas.SetActive(false);
    }
}
