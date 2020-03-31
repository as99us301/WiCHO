using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CO2Create : MonoBehaviour
{
    public GameObject CO2;
    public GameObject introd; //化合物簡介
    public GameObject COKE;
    public GameObject Instantiate_Pos1;
    public GameObject patentsPrefeb;
    public GameObject ButtonCanvas;
    public bool ColWith1O;
    public bool ColWith2O;
    public GameObject Ccanvas, Ocanvas;
    public GameObject[] ElementArray;
    private GameObject checkImage;
    public string puzzlebox = "";
    void Start()
    {
        checkImage = GameObject.Find("checkImage");
        ElementArray = GameObject.FindGameObjectsWithTag("Element");
    }
    void OnCollisionEnter(Collision collision) //當碰撞開始後
    {
        if (collision.gameObject.tag == "O")
        {
            if (puzzlebox == "")
            {
                ColWith1O = true;
                Debug.Log("KO NO DIO DA!");
                puzzlebox = collision.gameObject.name;
            }
            else if (puzzlebox != "" && collision.gameObject.name != puzzlebox)
            {
                ColWith2O = true;
                Debug.Log("WRRRRRRRRRRRRRRRRRRRRRRY");
            }
        }

        if (ColWith1O && ColWith2O)
        {
            CloseCanvas();
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(false);
            }
            checkImage.SetActive(false);
            GameObject CO21 = Instantiate(CO2, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
            CO21.transform.parent = patentsPrefeb.transform;
        }
    }

    void OnCollisionStay(Collision collision) //碰撞進行中
    {
        if (ColWith1O && ColWith2O)
        {
            ButtonCanvas.SetActive(true);
        }
    }

    void OnCollisionExit(Collision collision) //當碰撞結束後
    {
        if (collision.gameObject.tag == "O")
        {
            ColWith1O = false;
            ColWith2O = false;
            ButtonCanvas.SetActive(false);
            CleanObj();
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(true);
            }
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("OLayer"))
        {
            ColWith1O = false;
            ColWith2O = false;
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
        GameObject CO20 = Instantiate(CO2, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        CO20.transform.parent = patentsPrefeb.transform;
    }

    public void button2Click() //液體按鈕
    {
        CleanObj();
        introd.SetActive(false);
    }

    public void COKEClick() //氣體按鈕
    {
        CleanObj();
        GameObject COKEcola1 = Instantiate(COKE, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        COKEcola1.transform.parent = patentsPrefeb.transform;
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
        Destroy(GameObject.Find("CO2_Prefeb(Clone)"));
        Destroy(GameObject.Find("COKE(Clone)"));
    }

    public void CloseCanvas()
    {
        Ccanvas.SetActive(false);
        Ocanvas.SetActive(false);
    }
}
