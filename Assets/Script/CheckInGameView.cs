using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckInGameView : MonoBehaviour {

	public GameObject H1_ball, H2_ball, H3_ball, H4_ball, H5_ball, H6_ball, H7_ball, H8_ball, H9_ball, H10_ball;
	private Renderer H1_Renderer, H2_Renderer, H3_Renderer, H4_Renderer, H5_Renderer, H6_Renderer, H7_Renderer, H8_Renderer, H9_Renderer, H10_Renderer;
	public GameObject checkImage;

	public GameObject C1_ball, C2_ball, C3_ball, C4_ball, C5_ball, C6_ball, C7_ball, C8_ball, C9_ball, C10_ball;
	private Renderer C1_Renderer, C2_Renderer, C3_Renderer, C4_Renderer, C5_Renderer, C6_Renderer, C7_Renderer, C8_Renderer, C9_Renderer, C10_Renderer;

	public GameObject H_canva, C_canva, O_canva, Ca_canva, Na_canva, Cu_canva, Mg_canva, S_canva, N_canva, OH_canva, Cl_canva;
	public bool HshowUp, CshowUp, OshowUp, CashowUp, Nashowup, CushowUp, MgshowUp, SshowUp, NshowUp, OHshowUp, ClshowUp;


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
		if (HshowUp) //H顯示
		{
			checkImage.SetActive(false);
			H_canva.SetActive(true);
		} else { //H消失
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
