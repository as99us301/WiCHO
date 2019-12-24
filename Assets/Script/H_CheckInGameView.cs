using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_CheckInGameView : MonoBehaviour {

	public GameObject H1_ball, H2_ball, H3_ball, H4_ball, H5_ball, H6_ball, H7_ball, H8_ball, H9_ball, H10_ball;
	private Renderer H1_Renderer, H2_Renderer, H3_Renderer, H4_Renderer, H5_Renderer, H6_Renderer, H7_Renderer, H8_Renderer, H9_Renderer, H10_Renderer;
	public GameObject checkImage;
	public GameObject H_canva;
	

	// Use this for initialization
	void Start () {
		checkImage.SetActive(true);
		H1_Renderer = H1_ball.GetComponent<Renderer>();
		H2_Renderer = H2_ball.GetComponent<Renderer>();
		H3_Renderer = H3_ball.GetComponent<Renderer>();
		H4_Renderer = H4_ball.GetComponent<Renderer>();
		H5_Renderer = H5_ball.GetComponent<Renderer>();
		H6_Renderer = H6_ball.GetComponent<Renderer>();
		H7_Renderer = H7_ball.GetComponent<Renderer>();
		H8_Renderer = H8_ball.GetComponent<Renderer>();
		H9_Renderer = H9_ball.GetComponent<Renderer>();
		H10_Renderer = H10_ball.GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (H1_IsVisible() || H2_IsVisible() || H3_IsVisible() || H4_IsVisible() || H5_IsVisible() || H6_IsVisible() || H7_IsVisible() || H8_IsVisible() || H9_IsVisible() || H10_IsVisible())
		{
			checkImage.SetActive(false);
			H_canva.SetActive(true);
		}
		else 
		{
			checkImage.SetActive(true);
			H_canva.SetActive(false);
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
	public bool H3_IsVisible()
	{
		return H3_Renderer.isVisible;
	}
	public bool H4_IsVisible()
	{
		return H4_Renderer.isVisible;
	}
	public bool H5_IsVisible()
	{
		return H5_Renderer.isVisible;
	}
	public bool H6_IsVisible()
	{
		return H6_Renderer.isVisible;
	}
	public bool H7_IsVisible()
	{
		return H7_Renderer.isVisible;
	}
	public bool H8_IsVisible()
	{
		return H8_Renderer.isVisible;
	}
	public bool H9_IsVisible()
	{
		return H9_Renderer.isVisible;
	}
	public bool H10_IsVisible()
	{
		return H10_Renderer.isVisible;
	}
}
