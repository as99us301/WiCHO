using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureTest : MonoBehaviour
{
    public GameObject tutor;
    private Animator animator;
    private bool isComeOut;

    public void Start()
    {
        animator = tutor.GetComponent<Animator>();
        isComeOut = animator.GetBool("ComeOut");
    }

    public void Open()
    {
        if (tutor != null)
        {
            if (animator != null)
            {
                if (!isComeOut)
                {
                    UpMenu();
                }
                else
                {
                    DownMenu();
                }
            }
        }
    }

    public void UpMenu()
    {
        tutor.SetActive(true);
        isComeOut = true;
        animator.SetBool("ComeOut", isComeOut);
    }

    public void DownMenu()
    {
        isComeOut = false;
        animator.SetBool("ComeOut", isComeOut);
        tutor.SetActive(false);
    }
}
