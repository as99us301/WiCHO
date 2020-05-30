using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabOpenPanel : MonoBehaviour
{
    public GameObject Menupanel;
    public GameObject SwipePanel;
    private Animator animator;
    private bool labisOpen;
    private bool labisSwipeOn;
    private Animator Swipeanimator;

    public void Start()
    {
        animator = Menupanel.GetComponent<Animator>();
        labisOpen = animator.GetBool("OpenLabPanel");
        Swipeanimator = SwipePanel.GetComponent<Animator>();
        labisSwipeOn = animator.GetBool("LabSwipeOn");
        SwipeON();
    }

    public void Open()
    {
        if (Menupanel != null)
        {
            if (animator != null)
            {
                if (!labisOpen)
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
        labisOpen = true;
        animator.SetBool("OpenLabPanel", labisOpen);
    }

    public void DownMenu()
    {
        labisOpen = false;
        animator.SetBool("OpenLabPanel", labisOpen);
    }

    public void SwipeON()
    {
        labisSwipeOn = true;
        Swipeanimator.SetBool("LabSwipeOn", labisSwipeOn);
    }
    public void SwipeDown()
    {
        labisSwipeOn = false;
        Swipeanimator.SetBool("LabSwipeOn", labisSwipeOn);
    }
}
