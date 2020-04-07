using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H2O2P3 : MonoBehaviour
{
    public bool H2O2DONE;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "O")
        {
            H2O2DONE = collision.gameObject.GetComponent<h2o2p1>().colwithh;
        }

        if (H2O2DONE) Debug.Log("rerorerorerorero");
    }
}
