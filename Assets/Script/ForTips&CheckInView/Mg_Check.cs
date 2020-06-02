using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mg_Check : MonoBehaviour
{
    public GameObject[] MgballArray;
    private Renderer Mg1_Renderer, Mg2_Renderer, Mg3_Renderer, Mg4_Renderer, Mg5_Renderer;

    public GameObject Mg_canva;
    public bool MgshowUp;

    void Start()
    {
        Mg1_Renderer = MgballArray[0].GetComponent<MeshRenderer>();
        Mg2_Renderer = MgballArray[1].GetComponent<MeshRenderer>();
        Mg3_Renderer = MgballArray[2].GetComponent<MeshRenderer>();
        Mg4_Renderer = MgballArray[3].GetComponent<MeshRenderer>();
        Mg5_Renderer = MgballArray[4].GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        if (MgshowUp)
        {
            Mg_canva.SetActive(false);
        }

        if (Mg1_Renderer.isVisible || Mg2_Renderer.isVisible || Mg3_Renderer.isVisible || Mg4_Renderer.isVisible || Mg5_Renderer.isVisible)
        {
            MgshowUp = true;
        }
        else
        {
            MgshowUp = false;
        }

        if (MgshowUp)
        {
            Mg_canva.SetActive(true);
        }
        else
        {
            Mg_canva.SetActive(false);
        }
    }

    public bool Mg1_IsVisible()
    {
        return Mg1_Renderer.isVisible;
    }
    public bool Mg2_IsVisible()
    {
        return Mg2_Renderer.isVisible;
    }
    public bool Mg3_IsVisible()
    {
        return Mg3_Renderer.isVisible;
    }
    public bool Mg4_IsVisible()
    {
        return Mg4_Renderer.isVisible;
    }
    public bool Mg5_IsVisible()
    {
        return Mg5_Renderer.isVisible;
    }
}
