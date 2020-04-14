using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SO2Create : MonoBehaviour
{
    public GameObject SO2;
    public GameObject introd; //化合物簡介
    public GameObject Instantiate_Pos1;
    public GameObject patentsPrefeb;
    public GameObject ButtonCanvas;
    public GameObject thing1;
    public bool ColWithO1;
    public bool ColWithO2;
    public GameObject Scanvas, Ocanvas;
    public GameObject[] ElementArray;
    private GameObject checkImage;
    public string SO2puzzlebox = "";
    void Start()
    {
        checkImage = GameObject.Find("checkImage");
        ElementArray = GameObject.FindGameObjectsWithTag("Element");
    }
    void OnCollisionEnter(Collision collision) //當碰撞開始後
    {
        if (collision.gameObject.tag == "O")
        {
            if (SO2puzzlebox == "")
            {
                ColWithO1 = true;
                SO2puzzlebox = collision.gameObject.name;
                Debug.Log("Wryyyyyyyyyyyyy");
            }
            else if (SO2puzzlebox != "" && collision.gameObject.name != SO2puzzlebox)
            {
                ColWithO2 = true;
                Debug.Log("Ora");
            }
        }

        if (ColWithO1 && ColWithO2)
        {
            CloseCanvas();
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(false);
            }
            checkImage.SetActive(false);
            GameObject SO21 = Instantiate(SO2, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
            SO21.transform.parent = patentsPrefeb.transform;
        }
    }

    void OnCollisionStay(Collision collision) //碰撞進行中
    {
        if (ColWithO1 && ColWithO2)
        {
            ButtonCanvas.SetActive(true);
        }
    }

    void OnCollisionExit(Collision collision) //當碰撞結束後
    {
        if (collision.gameObject.tag == "O")
        {
            ColWithO1 = false;
            ColWithO2 = false;
            ButtonCanvas.SetActive(false);
            CleanObj();
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(true);
            }
            SO2puzzlebox = "";
        }
    }

    public void button1Click() //分子結構按鈕
    {
        CleanObj();
        introd.SetActive(false);
        GameObject SO20 = Instantiate(SO2, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        SO20.transform.parent = patentsPrefeb.transform;
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
        GameObject thing0 = Instantiate(thing1, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        thing0.transform.parent = patentsPrefeb.transform;
        introd.SetActive(false);
    }

    public void button5Click() //簡介按鈕
    {
        CleanObj();
        introd.SetActive(true);
    }

    public void CleanObj() //清理生成出來的物件
    {
        Destroy(GameObject.Find("SO2_Prefeb(Clone)"));
    }

    public void CloseCanvas()
    {
        Scanvas.SetActive(false);
        Ocanvas.SetActive(false);
    }
}
