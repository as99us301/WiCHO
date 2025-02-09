﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CcheckinView : MonoBehaviour
{
    private Renderer C1_Renderer, C2_Renderer, C3_Renderer, C4_Renderer, C5_Renderer;
    public GameObject C1_ball, C2_ball, C3_ball, C4_ball, C5_ball;

    public GameObject C_canva;
    public bool CshowUp;

    void Start()
    {
        //test = gameObject.GetComponent<TipscheckinView>().HshowUp;
        C1_Renderer = C1_ball.GetComponent<MeshRenderer>();
        C2_Renderer = C2_ball.GetComponent<MeshRenderer>();
        C3_Renderer = C3_ball.GetComponent<MeshRenderer>();
        C4_Renderer = C4_ball.GetComponent<MeshRenderer>();
        C5_Renderer = C5_ball.GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        if (CshowUp)
        {
            C_canva.SetActive(false);
        }

        if (C1_Renderer.isVisible || C2_Renderer.isVisible || C3_Renderer.isVisible || C4_Renderer.isVisible || C5_Renderer.isVisible)
        {
            CshowUp = true;
        }
        else
        {
            CshowUp = false;
        }

        if (CshowUp)
        {
            C_canva.SetActive(true);
        }
        else
        {
            C_canva.SetActive(false);
        }
    }

    public bool C1_IsVisible()
    {
        return C1_Renderer.isVisible;
    }
    public bool C2_IsVisible()
    {
        return C2_Renderer.isVisible;
    }
    public bool C3_IsVisible()
    {
        return C3_Renderer.isVisible;
    }
    public bool C4_IsVisible()
    {
        return C4_Renderer.isVisible;
    }
    public bool C5_IsVisible()
    {
        return C5_Renderer.isVisible;
    }
}
