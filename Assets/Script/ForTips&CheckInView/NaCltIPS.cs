using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaCltIPS : MonoBehaviour
{
    public bool NaShowUp, ClShowUp;
    public GameObject Nacanva, Clcanva, NaClCanva;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NaShowUp = gameObject.GetComponent<NacheckinView>().NashowUp;
        ClShowUp = gameObject.GetComponent<ClcheckinView>().ClshowUp;

        if (NaShowUp && ClShowUp)
        {
            CloseCanvas();
            NaClCanva.SetActive(true);
            Debug.Log("hi");
           
        }
        else
        {
            NaClCanva.SetActive(false);
        }
    }

    public void CloseCanvas()
    {
        Nacanva.SetActive(false);
        Clcanva.SetActive(false);
    }
}
