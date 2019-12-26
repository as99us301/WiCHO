using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookatCamera : MonoBehaviour {

    public Transform obj;
    public Transform Camera;

    // Update is called once per frame
    void Update()
    {
        obj.LookAt(Camera);
    }

}
