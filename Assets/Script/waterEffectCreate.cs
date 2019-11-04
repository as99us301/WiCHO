using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterEffectCreate : MonoBehaviour {

    public GameObject waterEffect;
    
    public void Start()
    {
        //waterEffect = kettle.transform.GetChild(0).gameObject;
        GameObject root = GameObject.Find("kettle(Clone)");
        waterEffect = root.transform.Find("water").gameObject;
        
    }

    // Use this for initialization
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "kettle")
        {
            waterEffect.SetActive(true);
        }
      
    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "kettle")
        {
            waterEffect.SetActive(false);
        }
    }
}
