using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour {

	public void GallaryOnClick()
    {
        Application.LoadLevel(0);
    }
    public void AROnClick()
    {
        Application.LoadLevel(1);
    }
    public void LabOnClick()
    {
        Application.LoadLevel(0);
    }

    public void GameOnClick()
    {
        Application.LoadLevel(2);
    }
    public void ExbisionOnClick()
    {
        Application.LoadLevel(3);
    }
    public void backtoIndex()
    {
        Application.LoadLevel(0);
    }

}
