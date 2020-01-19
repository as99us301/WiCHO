using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClcheckinView : MonoBehaviour
{
    private Renderer Cl1_Renderer, Cl2_Renderer, Cl3_Renderer, Cl4_Renderer, Cl5_Renderer;
    public GameObject Cl1_ball, Cl2_ball, Cl3_ball, Cl4_ball, Cl5_ball;

    public GameObject Cl_canva;
    public bool ClshowUp;

    void Start()
    {
        //test = gameObject.GetComponent<TipscheckinView>().HshowUp;
        Cl1_Renderer = Cl1_ball.GetComponent<MeshRenderer>();
        Cl2_Renderer = Cl2_ball.GetComponent<MeshRenderer>();
        Cl3_Renderer = Cl3_ball.GetComponent<MeshRenderer>();
        Cl4_Renderer = Cl4_ball.GetComponent<MeshRenderer>();
        Cl5_Renderer = Cl5_ball.GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        if (ClshowUp)
        {
            Cl_canva.SetActive(false);
        }

        if (Cl1_Renderer.isVisible || Cl2_Renderer.isVisible || Cl3_Renderer.isVisible || Cl4_Renderer.isVisible || Cl5_Renderer.isVisible)
        {
            ClshowUp = true;
        }
        else
        {
            ClshowUp = false;
        }

        if (ClshowUp)
        {
            Cl_canva.SetActive(true);
        }
        else
        {
            Cl_canva.SetActive(false);
        }
    }

    public bool Cl1_IsVisible()
    {
        return Cl1_Renderer.isVisible;
    }
    public bool Cl2_IsVisible()
    {
        return Cl2_Renderer.isVisible;
    }
    public bool Cl3_IsVisible()
    {
        return Cl3_Renderer.isVisible;
    }
    public bool Cl4_IsVisible()
    {
        return Cl4_Renderer.isVisible;
    }
    public bool Cl5_IsVisible()
    {
        return Cl5_Renderer.isVisible;
    }
}
