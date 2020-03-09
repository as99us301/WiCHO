using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class labFire : MonoBehaviour
{

    public ParticleSystem OriginFire;
    public ParticleSystem Yellow, BrickRed, GrandGreen, Green, Purple, Red, YellowGreen;


    //BaCl2, CaCO3, CuSO4, H3BO3, KCl, LiCl, NaCl
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BaCl2") 
        {
            OriginFire.Stop();
            YellowGreen.Play();
        }else if (collision.gameObject.tag == "CaCO3")
        {
            OriginFire.Stop();
            BrickRed.Play();
        }else if (collision.gameObject.tag == "CuSO4")
        {
            OriginFire.Stop();
            GrandGreen.Play();
        }else if (collision.gameObject.tag == "H3BO3")
        {
            OriginFire.Stop();
            Green.Play();
        }else if (collision.gameObject.tag == "KCl")
        {
            OriginFire.Stop();
            Purple.Play();
        }else if (collision.gameObject.tag == "LiCl")
        {
            OriginFire.Stop();
            Red.Play();
        }else if (collision.gameObject.tag == "NaCl")
        {
            OriginFire.Stop();
            Yellow.Play();
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "BaCl2")
        {
            OriginFire.Play();
            YellowGreen.Stop();
        }else if (collision.gameObject.tag == "CaCO3")
        {
            OriginFire.Play();
            BrickRed.Stop();
        }else if (collision.gameObject.tag == "CuSO4")
        {
            OriginFire.Play();
            GrandGreen.Stop();
        }else if (collision.gameObject.tag == "H3BO3")
        {
            OriginFire.Play();
            Green.Stop();
        }else if (collision.gameObject.tag == "KCl")
        {
            OriginFire.Play();
            Purple.Stop();
        }else if (collision.gameObject.tag == "LiCl")
        {
            OriginFire.Play();
            Red.Stop();
        }else if (collision.gameObject.tag == "NaCl")
        {
            OriginFire.Play();
            Yellow.Stop();
        }
    }

}
