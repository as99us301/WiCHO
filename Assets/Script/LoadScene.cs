using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	public void GallaryOnClick()
    {
        SceneManager.LoadScene("Element");
        //Application.LoadLevel(4);
    }
    public void AROnClick()
    {
        SceneManager.LoadScene("AR_index");
        //Application.LoadLevel(1);
    }
    public void LabOnClick()
    {
        SceneManager.LoadScene("Lab");
        //Application.LoadLevel(0);
    }

    public void GameOnClick()
    {
        SceneManager.LoadScene("NewGame");
        //Application.LoadLevel(2);
    }
    public void ExbisionOnClick()
    {
        SceneManager.LoadScene("Exhibition");
        //Application.LoadLevel(3);
    }
    public void backtoIndex()
    {
        SceneManager.LoadScene("index");
        //Application.LoadLevel(0);
    }
}
