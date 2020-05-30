using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cO2 : MonoBehaviour
{
    public GameObject CO2;
    public GameObject introd; //化合物簡介
    public GameObject COKECOLA;
    public GameObject Instantiate_Pos1;
    public GameObject patentsPrefeb;
    public GameObject ButtonCanvas;
    private bool ColWithO1;
    private bool ColWithO2;
    public GameObject Ccanvas, Ocanvas;
    public GameObject[] ElementArray;
    private GameObject checkImage;
    private string CO2puzzlebox = "";

    void Start()
    {
        checkImage = GameObject.Find("checkImage");
        ElementArray = GameObject.FindGameObjectsWithTag("Element");
    }
    void OnCollisionEnter(Collision collision) //當碰撞開始後
    {
        if (collision.gameObject.tag == "O")
        {
            if (CO2puzzlebox == "")
            {
                ColWithO1 = true;
                CO2puzzlebox = collision.gameObject.name;
            }
            else if (CO2puzzlebox != "" && collision.gameObject.name != CO2puzzlebox)
            {
                ColWithO2 = true;
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
            GameObject CO21 = Instantiate(CO2, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
            CO21.transform.parent = patentsPrefeb.transform;
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
            CO2puzzlebox = "";
        }
    }

    public void button1Click() //分子結構按鈕
    {
        CleanObj();
        introd.SetActive(false);
        GameObject CO202 = Instantiate(CO2, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        CO202.transform.parent = patentsPrefeb.transform;
    }

    public void COKEClick() //氣體按鈕
    {
        CleanObj();
        introd.SetActive(false);
        GameObject COKE = Instantiate(COKECOLA, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
        COKE.transform.parent = patentsPrefeb.transform;
    }

    public void button5Click() //簡介按鈕
    {
        CleanObj();
        introd.SetActive(true);
    }

    public void CleanObj() //清理生成出來的物件
    {
        Destroy(GameObject.Find("GameObject(Clone)"));
        Destroy(GameObject.Find("CO2(Clone)"));
    }

    public void CloseCanvas()
    {
        Ccanvas.SetActive(false);
        Ocanvas.SetActive(false);
    }

}
