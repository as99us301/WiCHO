using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H2o2test : MonoBehaviour
{
    public GameObject ball;
    public GameObject pos;
    public bool h2o2DONE;
    public GameObject patentsPrefeb;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "NewBox")
        {
            h2o2DONE = true;
            if (collision.gameObject.GetComponent<H2o2test>().h2o2DONE != true)
            {
                GameObject H2Oo2 = Instantiate(ball, pos.transform.position, pos.transform.rotation);
                H2Oo2.transform.parent = patentsPrefeb.transform;
            }
            else
            {
                return;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "NewBox")
        {
            h2o2DONE = false;
            Destroy(GameObject.Find("H2O2(Clone)"));
        }
    }
}
