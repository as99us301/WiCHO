using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TipscheckinView : MonoBehaviour
{
    private Renderer H1_Renderer, H2_Renderer;
    public GameObject H1_ball, H2_ball;
       
    public GameObject H_canva;
    public bool HshowUp;

    void Start()
    {       
        H1_Renderer = H1_ball.GetComponent<MeshRenderer>();
        H2_Renderer = H2_ball.GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        if (H1_Renderer.isVisible || H2_Renderer.isVisible)
        {
            HshowUp = true;
        }
        else 
        {
            HshowUp = false;
        }

        if (HshowUp)
        {
            H_canva.SetActive(true);
        }
        else {
            H_canva.SetActive(false);
        }
    }

    public bool H1_IsVisible()
    {
        return H1_Renderer.isVisible;
    }
    public bool H2_IsVisible()
    {
        return H2_Renderer.isVisible;
    }
}