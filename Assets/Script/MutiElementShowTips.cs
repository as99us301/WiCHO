using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutiElementShowTips : MonoBehaviour
{
    public bool HshowUp, OshowUp, CshowUp;
    public GameObject Hcanva, Ocanva, Ccanva, OandHcanva, CandOcanva, CandHcanva;
    //public GameObject[] TipsCanvaArray;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        HshowUp = gameObject.GetComponent<TipscheckinView>().HshowUp;
        OshowUp = gameObject.GetComponent<Otest>().OshowUp;
        CshowUp = gameObject.GetComponent<CheckCInView>().CshowUp;

        if (HshowUp && OshowUp)
        {
            OandHcanva.SetActive(true);
            Ocanva.SetActive(false);
            Hcanva.SetActive(false);
        }
        else 
        {
            OandHcanva.SetActive(false);
        }

        if (CshowUp && OshowUp) 
        {
            CandOcanva.SetActive(true);
            Ccanva.SetActive(false);
            Ocanva.SetActive(false);
        }
        else
        {
            CandOcanva.SetActive(false);
        }

        if (CshowUp && HshowUp)
        {
            CandHcanva.SetActive(true);
            Ccanva.SetActive(false);
            Hcanva.SetActive(false);
        }
        else
        {
            CandHcanva.SetActive(false);
        }


        /*for (int i = 0; i < TipsCanvaArray.Length; i++)
        {
            TipsCanvaArray[i].gameObject.SetActive(false);
        }*/
    }
}
