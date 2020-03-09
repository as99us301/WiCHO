using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    public GameObject Menupanel;
    private Animator animator;
    private bool isOpen;

    public void Start()
    {
        animator = Menupanel.GetComponent<Animator>();
        isOpen = animator.GetBool("Open");
    }

    public void Open() {
        if (Menupanel != null) {

            if (animator != null) {

                if (!isOpen) {
                    UpMenu();
                }else{
                    DownMenu();
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
}
