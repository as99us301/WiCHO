using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaClCreate : MonoBehaviour
{
    public GameObject NaCl;
    public GameObject Instantiate_Pos1;
    public GameObject Instantiate_Pos2;
    public GameObject patentsPrefeb;
    private bool ColWithP1 = false;
    private bool ColWithP2 = false;

    public GameObject[] ElementArray;
    public GameObject Nacanvas, Clcanvas;
    private GameObject checkImage;

    public bool NaClCompelete;

    void Start()
    {
        checkImage = GameObject.Find("checkImage");
        ElementArray = GameObject.FindGameObjectsWithTag("Element");
    }

    void OnCollisionEnter(Collision collision) //當碰撞開始後
    {
        if (collision.gameObject.tag == "Na")
        {
            ColWithP1 = true;
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("Num6"))
        {
            ColWithP2 = true;
        }

        if (ColWithP1 && ColWithP2)
        {
            NaClCompelete = true;
            checkImage.SetActive(false);

            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(false);
            }
            CloseCanvas();
        }

        if (NaClCompelete)
        {
            GameObject NaCl_obj = Instantiate(NaCl, Instantiate_Pos1.transform.position, Instantiate_Pos1.transform.rotation);
            NaCl_obj.transform.parent = patentsPrefeb.transform;
        }
        else
        {
            Destroy(GameObject.Find("NaCl(Clone)"));
        }

    }

    void OnCollisionStay(Collision collision) //碰撞進行中
    {
        if (ColWithP1 && ColWithP2)
        {
            checkImage.SetActive(false);
            return;
        }
    }

    void OnCollisionExit(Collision collision) //當碰撞結束後
    {
        if (collision.gameObject.tag == "Na")
        {
            ColWithP1 = false;
            ColWithP2 = false;
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(true);
            }
            Destroy(GameObject.Find("NaCl(Clone)"));
            NaClCompelete = false;
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("Num6"))
        {
            ColWithP1 = false;
            ColWithP2 = false;
            for (int i = 0; i < ElementArray.Length; i++)
            {
                ElementArray[i].gameObject.SetActive(true);
            }
            Destroy(GameObject.Find("NaCl(Clone)"));
            NaClCompelete = false;
        }
    }

    public void CleanObj() //清理生成出來的物件
    {
        Destroy(GameObject.Find("NaCl(Clone)"));
    }
    public void CloseCanvas()
    {
        Clcanvas.SetActive(false);
        Nacanvas.SetActive(false);
    }
}
