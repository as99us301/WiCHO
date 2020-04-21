using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstO3Box : MonoBehaviour
{
    public GameObject O3Box;
    public string puzzleboxO3 = "";
    public bool ColWithO1;
    public bool ColWithO2;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "O")
        {
            if (puzzleboxO3 == "")
            {
                ColWithO1 = true;
                puzzleboxO3 = collision.gameObject.name;
            }
            else if (puzzleboxO3 != "" && collision.gameObject.name != puzzleboxO3)
            {
                ColWithO2 = true;
            }

            if (ColWithO1 && ColWithO2)
            {
                O3Box.SetActive(true);
            }
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "O")
        {
            O3Box.SetActive(false);
            ColWithO1 = false;
            ColWithO2 = false;
            puzzleboxO3 = "";
        }
    }
}
