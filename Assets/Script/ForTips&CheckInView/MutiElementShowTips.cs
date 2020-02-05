using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutiElementShowTips : MonoBehaviour
{
    private bool HshowUp, OshowUp, CshowUp;
    public GameObject Hcanva, Ocanva, Ccanva, OandHcanva, CandOcanva, CandHcanva;

    void Update()
    {
        HshowUp = gameObject.GetComponent<HcheckinView>().HshowUp;
        OshowUp = gameObject.GetComponent<OcheckinView>().OshowUp;
        CshowUp = gameObject.GetComponent<CcheckinView>().CshowUp;

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
    }
}
