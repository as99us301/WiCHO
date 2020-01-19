using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NacheckinView : MonoBehaviour
{
    private Renderer Na1_Renderer, Na2_Renderer, Na3_Renderer, Na4_Renderer, Na5_Renderer;
    public GameObject Na1_ball, Na2_ball, Na3_ball, Na4_ball, Na5_ball;

    public GameObject Na_canva;
    public bool NashowUp;

    void Start()
    {
        //test = gameObject.GetComponent<TipscheckinView>().HshowUp;
        Na1_Renderer = Na1_ball.GetComponent<MeshRenderer>();
        Na2_Renderer = Na2_ball.GetComponent<MeshRenderer>();
        Na3_Renderer = Na3_ball.GetComponent<MeshRenderer>();
        Na4_Renderer = Na4_ball.GetComponent<MeshRenderer>();
        Na5_Renderer = Na5_ball.GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        if (NashowUp)
        {
            Na_canva.SetActive(false);
        }

        if (Na1_Renderer.isVisible || Na2_Renderer.isVisible || Na3_Renderer.isVisible || Na4_Renderer.isVisible || Na5_Renderer.isVisible)
        {
            NashowUp = true;
        }
        else
        {
            NashowUp = false;
        }

        if (NashowUp)
        {
            Na_canva.SetActive(true);
        }
        else
        {
            Na_canva.SetActive(false);
        }
    }

    public bool Na1_IsVisible()
    {
        return Na1_Renderer.isVisible;
    }
    public bool Na2_IsVisible()
    {
        return Na2_Renderer.isVisible;
    }
    public bool Na3_IsVisible()
    {
        return Na3_Renderer.isVisible;
    }
    public bool Na4_IsVisible()
    {
        return Na4_Renderer.isVisible;
    }
    public bool Na5_IsVisible()
    {
        return Na5_Renderer.isVisible;
    }
}
