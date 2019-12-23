using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckInGameView : MonoBehaviour {

	public GameObject H1_ball;
	public GameObject H2_ball;
	public GameObject O_ball;
	private Renderer H1_Renderer;
	private Renderer H2_Renderer;
	private Renderer O_Renderer;
	public GameObject checkImage;
	

	// Use this for initialization
	void Start () {
		checkImage.SetActive(true);
		H1_Renderer = H1_ball.GetComponent<Renderer>();
		H2_Renderer = H2_ball.GetComponent<Renderer>();
		O_Renderer = O_ball.GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (H1_IsVisible() || H2_IsVisible() || O_IsVisible())
		{
			checkImage.SetActive(false);
		}
		else 
		{
			checkImage.SetActive(true);
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
