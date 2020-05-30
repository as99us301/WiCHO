using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    public GameObject Menupanel;
    public GameObject SwipePanel;
    private Animator animator;
    private bool isOpen;
    private bool isSwipeOn;
    private Animator Swipeanimator;

    public void Start()
    {
        animator = Menupanel.GetComponent<Animator>();
        isOpen = animator.GetBool("Open");
        Swipeanimator = SwipePanel.GetComponent<Animator>();
        isSwipeOn = animator.GetBool("LabSwipeOn");
        SwipeON();
    }

    public void Open()
    {
        if (Menupanel != null)
        {
            if (animator != null)
            {
                if (!isOpen)
                {
                    UpMenu();
                    SwipeDown();
                }
                else
                {
                    DownMenu();
                    SwipeON();
                }
            }
        }
    }

    public void UpMenu()
    {
        isOpen = true;
        animator.SetBool("Open", isOpen);
    }

    public void DownMenu()
    {
        isOpen = false;
        animator.SetBool("Open", isOpen);
    }
    
    public void SwipeON() {
        isSwipeOn = true;
        Swipeanimator.SetBool("LabSwipeOn", isSwipeOn);
    }
    public void SwipeDown()
    {
        isSwipeOn = false;
        Swipeanimator.SetBool("LabSwipeOn", isSwipeOn);
    }
}
