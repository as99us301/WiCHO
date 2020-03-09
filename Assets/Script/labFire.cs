using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class labFire : MonoBehaviour
{
    public GameObject light;
    public GameObject fire;
    public GameObject spoon;
    public GameObject pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "O") 
        {
            Instantiate(fire, transform.position, transform.rotation);
        
        }
    }

    public void test() 
    {
        Instantiate(spoon, pos.transform.position, pos.transform.rotation);
    }
}
