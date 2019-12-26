using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class CheckinView : MonoBehaviour
{
    private Renderer H1_Renderer;
    private Renderer H2_Renderer;
    private Renderer O_Renderer;

    public GameObject H1_ball;
    public GameObject H2_ball;
    public GameObject O_ball;
    public GameObject totu01;
    public GameObject totu02;
    public GameObject totu03;
    public GameObject totu04;
    public GameObject totu05;

    private bool ocheck;
    private bool hDiss = true;

    void Start()
    {
        H1_Renderer = H1_ball.GetComponent<Renderer>();
        H2_Renderer = H2_ball.GetComponent<Renderer>();
        O_Renderer = O_ball.GetComponent<Renderer>();
        totu01.SetActive(true);
        totu02.SetActive(false);
        totu03.SetActive(false);
        totu04.SetActive(false);
        totu05.SetActive(false);
    }

    void Update()
    {
        //當一個H出現時
        if (H1_IsVisible() || H2_IsVisible())
        {
            totu01.SetActive(false);
            totu02.SetActive(true);
            totu03.SetActive(false);
            totu04.SetActive(false);
            totu05.SetActive(false);
            hDiss = false;
        }
        else if (!hDiss) //當H消失時
        {
            //Debug.Log("非表示中");
            totu01.SetActive(true);
            totu02.SetActive(false);
            totu03.SetActive(false);
            totu04.SetActive(false);
            totu05.SetActive(false);
            hDiss = true;
        }

        //當O出現時
        if ((H1_IsVisible() || H2_IsVisible()) && O_IsVisible())
        {
            //Debug.Log("表示中");
            totu01.SetActive(false);
            totu02.SetActive(false);
            totu03.SetActive(true);
            totu04.SetActive(false);
            totu05.SetActive(false);
            ocheck = true;
        }
        else if ((H1_IsVisible() || H2_IsVisible())) //當O消失時
        {
            //Debug.Log("非表示中");
            totu01.SetActive(false);
            totu02.SetActive(true);
            totu03.SetActive(false);
            totu04.SetActive(false);
            totu05.SetActive(false);
            ocheck = false;
        }

        //當第二個H出現時
        if (ocheck && H1_IsVisible() && H2_IsVisible())
        {
            //Debug.Log("表示中");
            totu01.SetActive(false);
            totu02.SetActive(false);
            totu03.SetActive(false);
            totu04.SetActive(true);
            totu05.SetActive(false);
        }
        else if (ocheck && (H1_IsVisible() || H2_IsVisible())) //當第二個H消失時
        {
            //Debug.Log("非表示中");
            totu01.SetActive(false);
            totu02.SetActive(false);
            totu03.SetActive(true);
            totu04.SetActive(false);
            totu05.SetActive(false);
        }
    }

    //回傳
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
