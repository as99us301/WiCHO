using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testtttttt : MonoBehaviour
{
    public Animation animation;
    void Start()
    {
        this.GetComponent<Animation>().Play("FakeLoading");
    }

}
