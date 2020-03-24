using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Na2OCreate : MonoBehaviour
{
    public GameObject Na2O;
    public GameObject introd; //化合物簡介
    public GameObject Instantiate_Pos1;
    public GameObject patentsPrefeb;
    public GameObject ButtonCanvas;
    public bool ColWith1NA;
    public bool ColWith2NA;
    public GameObject Nacanvas, Ocanvas;
    public GameObject[] ElementArray;
    private GameObject checkImage;
    void Start()
    {
        checkImage = GameObject.Find("checkImage");
        ElementArray = GameObject.FindGameObjectsWithTag("Element");
    }
    void OnCollisionEnter(Collision collision) //當碰撞開始後
    {
        if (collision.gameObject.tag == "Na1")
        {
            ColWith1NA = true;
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("NaLayer"))
        {
            ColWith2NA = true;
        }

        if (ColWith1NA && ColWith2NA)
        {
            CloseCanvas();
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(false);
            }
            checkImage.SetActive(false);
            GameObject Na2O1 = Instantiate(Na2O, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
            Na2O1.transform.parent = patentsPrefeb.transform;
        }
    }

    void OnCollisionStay(Collision collision) //碰撞進行中
    {
        if (ColWith1NA && ColWith2NA)
        {
            ButtonCanvas.SetActive(true);
        }
    }

    void OnCollisionExit(Collision collision) //當碰撞結束後
    {
        if (collision.gameObject.tag == "Na1")
        {
            ColWith1NA = false;
            ColWith2NA = false;
            ButtonCanvas.SetActive(false);
            CleanObj();
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(true);
            }
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("NaLayer"))
        {
            ColWith1NA = false;
            ColWith2NA = false;
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
        GameObject na2O0 = Instantiate(Na2O, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        na2O0.transform.parent = patentsPrefeb.transform;
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
        introd.SetActive(false);
    }

    public void button5Click() //簡介按鈕
    {
        CleanObj();
        introd.SetActive(true);
    }

    public void CleanObj() //清理生成出來的物件
    {
        Destroy(GameObject.Find("Na2O_Prefeb(Clone)"));
    }

    public void CloseCanvas()
    {
        Nacanvas.SetActive(false);
        Ocanvas.SetActive(false);
    }
}
