using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CO2Create : MonoBehaviour
{
    public GameObject Newthing;
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
        if (collision.gameObject.tag == "O")
        {
            ColWith1 = true;
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("Num4"))
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
            checkImage.SetActive(false);
            return;
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
            Destroy(GameObject.Find("CO2_Prefeb(Clone)"));
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("Num4"))
        {
            ColWith2 = false;
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(true);
            }
            Destroy(GameObject.Find("CO2_Prefeb(Clone)"));
        }
    }

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
