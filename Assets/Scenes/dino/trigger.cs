using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject text;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        text.SetActive(true);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        text.SetActive(false);
    }
}
