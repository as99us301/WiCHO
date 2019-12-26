using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTest : MonoBehaviour {

    // Use this for initialization
    public float speed = 10;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
