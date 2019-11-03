using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterEffectCreate : MonoBehaviour {

    public ParticleSystem waterEffect;
    // Use this for initialization
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "kettle")
        {
            waterEffect.Play();
        }
      
    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "kettle")
        {
            waterEffect.Stop();
        }
    }
}
