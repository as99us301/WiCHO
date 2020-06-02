using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_check : MonoBehaviour
{
    public GameObject[] SballArray;
    private Renderer S1_Renderer, S2_Renderer, S3_Renderer, S4_Renderer, S5_Renderer;
    
    public GameObject S_canva;
    public bool SshowUp;

    void Start()
    {
        S1_Renderer = SballArray[0].GetComponent<MeshRenderer>();
        S2_Renderer = SballArray[1].GetComponent<MeshRenderer>();
        S3_Renderer = SballArray[2].GetComponent<MeshRenderer>();
        S4_Renderer = SballArray[3].GetComponent<MeshRenderer>();
        S5_Renderer = SballArray[4].GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        if (SshowUp)
        {
            S_canva.SetActive(false);
        }

        if (S1_Renderer.isVisible || S2_Renderer.isVisible || S3_Renderer.isVisible || S4_Renderer.isVisible || S5_Renderer.isVisible)
        {
            SshowUp = true;
        }
        else
        {
            SshowUp = false;
        }

        if (SshowUp)
        {
            S_canva.SetActive(true);
        }
        else
        {
            S_canva.SetActive(false);
        }
    }

    public bool S1_IsVisible()
    {
        return S1_Renderer.isVisible;
    }
    public bool S2_IsVisible()
    {
        return S2_Renderer.isVisible;
    }
    public bool S3_IsVisible()
    {
        return S3_Renderer.isVisible;
    }
    public bool S4_IsVisible()
    {
        return S4_Renderer.isVisible;
    }
    public bool S5_IsVisible()
    {
        return S5_Renderer.isVisible;
    }
}
