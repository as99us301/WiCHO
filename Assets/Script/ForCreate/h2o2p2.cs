﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class h2o2p2 : MonoBehaviour
{
    public bool colwithh;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "H")
        {
            colwithh = true;
            Debug.Log("ORAORA!");
        }
    }
}
