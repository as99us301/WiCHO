using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otest : MonoBehaviour
{
    private Renderer O1_Renderer, O2_Renderer;
    public GameObject O1_ball, O2_ball;

    public GameObject O_canva;
    public bool OshowUp;

    void Start()
    {
        O1_Renderer = O1_ball.GetComponent<MeshRenderer>();
        O2_Renderer = O2_ball.GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        if (OshowUp) 
        {
            O_canva.SetActive(false);
        }

        if (O1_Renderer.isVisible || O2_Renderer.isVisible)
        {
            OshowUp = true;
        }
        else
        {
            OshowUp = false;
        }

        if (OshowUp)
        {
            O_canva.SetActive(true);
        }
        else
        {
            O_canva.SetActive(false);
        }
    }

    public bool H1_IsVisible()
    {
        return O1_Renderer.isVisible;
    }
    public bool H2_IsVisible()
    {
        return O2_Renderer.isVisible;
    }
}
