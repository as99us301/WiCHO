using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H2OCreate : MonoBehaviour {
    public GameObject newobj;
    public GameObject H_obj;
    public GameObject H2_obj;
    public GameObject O_obj;
    private bool ColWith1 = false;
    private bool ColWith2 = false ;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "H")
        {
            ColWith1 = true;
        } else if (collision.gameObject.layer == LayerMask.NameToLayer("Num3")) {
            ColWith2 = true;
        }


        if (ColWith1 && ColWith2)
        {
            H_obj.SetActive(false);
            H2_obj.SetActive(false);
            O_obj.SetActive(false);
            newobj.SetActive(true);
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "H")
        {
            ColWith1 = false;
            newobj.SetActive(false);
            H_obj.SetActive(true);
            H2_obj.SetActive(true);
            O_obj.SetActive(true);
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("Num3"))
        {
            ColWith2 = false;
            newobj.SetActive(false);
            H_obj.SetActive(true);
            H2_obj.SetActive(true);
            O_obj.SetActive(true);
        }
    }
}
