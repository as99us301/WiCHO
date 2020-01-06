using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otest : MonoBehaviour
{
    private Renderer O1_Renderer, O2_Renderer, O3_Renderer;
    public GameObject O1_ball, O2_ball, O3_ball;

    public GameObject O_canva;
    public bool OshowUp;

    void Start()
    {
        //test = gameObject.GetComponent<TipscheckinView>().HshowUp;
        O1_Renderer = O1_ball.GetComponent<MeshRenderer>();
        O2_Renderer = O2_ball.GetComponent<MeshRenderer>();
        O3_Renderer = O3_ball.GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        if (OshowUp) 
        {
            O_canva.SetActive(false);
        }

        if (O1_Renderer.isVisible || O2_Renderer.isVisible || O3_Renderer.isVisible)
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

    public bool O1_IsVisible()
    {
        return O1_Renderer.isVisible;
    }
    public bool O2_IsVisible()
    {
        return O2_Renderer.isVisible;
    }
    public bool O3_IsVisible()
    {
        return O3_Renderer.isVisible;
    }
}
