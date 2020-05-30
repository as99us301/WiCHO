using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class h2ocheck : MonoBehaviour
{
    public bool ifInScene = true;
    void OnBecameVisible()
    {
        ifInScene = true;
        Debug.Log("Show");
        Destroy(GameObject.Find("H2O2(Clone)"));
    }
    void OnBecameInvisible()
    {
        ifInScene = false;
        Debug.Log("Lost");
        
    }
}
