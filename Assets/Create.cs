using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour {
    public GameObject newobj;
    public GameObject H_obj;
    public GameObject O_obj;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "H2")
        {
            H_obj.SetActive(false);
            O_obj.SetActive(false);
            newobj.SetActive(true);
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "H2")
        {
            H_obj.SetActive(true);
            O_obj.SetActive(true);
            newobj.SetActive(false);
        }
    }
}
