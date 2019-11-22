using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class CheckinView : MonoBehaviour
{
    private Renderer H1_Renderer;
    private Renderer H2_Renderer;
    private Renderer O_Renderer;
    public GameObject image;
    public GameObject H1_ball;
    public GameObject H2_ball;
    public GameObject O_ball;

    void Start()
    {
        H1_Renderer = H1_ball.GetComponent<Renderer>();
        H2_Renderer = H2_ball.GetComponent<Renderer>();
        O_Renderer = O_ball.GetComponent<Renderer>();
    }

    void Update()
    {
        if (H1_IsVisible())
        {
            //Debug.Log("表示中");
            image.SetActive(false);
        }
        else
        {
            //Debug.Log("非表示中");
            image.SetActive(true);
        }
        if (H2_IsVisible())
        {
            //Debug.Log("表示中");
            image.SetActive(false);
        }
        else
        {
            //Debug.Log("非表示中");
            image.SetActive(true);
        }
        if (O_IsVisible())
        {
            //Debug.Log("表示中");
            image.SetActive(false);
        }
        else
        {
            //Debug.Log("非表示中");
            image.SetActive(true);
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
    public bool O_IsVisible()
    {
        return O_Renderer.isVisible;
    }
}
