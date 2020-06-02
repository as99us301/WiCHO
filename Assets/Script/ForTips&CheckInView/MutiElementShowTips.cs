using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutiElementShowTips : MonoBehaviour
{
    private bool HshowUp, OshowUp, CshowUp, SshowUp, NaShowUp, ClShowUp;
    public GameObject Hcanva, Ocanva, Ccanva, Scanva, Nacanva, Clcanva;
    public GameObject NONEcanva;
    public GameObject OandHcanva, CandOcanva, CandHcanva, SandHcanva, HandNAcanva, CandNa_canva, HandCl_Canva;

    public void Update()
    {
        GetScriptBool();

        if (HshowUp)
        {
            if (OshowUp)
            {
                OandHcanva.SetActive(true);
                Ocanva.SetActive(false);
                Hcanva.SetActive(false);
            }
            else if (CshowUp)
            {
                CandHcanva.SetActive(true);
                Ccanva.SetActive(false);
                Hcanva.SetActive(false);
            }
            else if (NaShowUp)
            {
                HandNAcanva.SetActive(true);
                Nacanva.SetActive(false);
                Hcanva.SetActive(false);
            }
            else if (ClShowUp)
            {
                HandCl_Canva.SetActive(true);
                Clcanva.SetActive(false);
                Hcanva.SetActive(false);
            }
            else if (SshowUp)
            {
                SandHcanva.SetActive(true);
                Scanva.SetActive(false);
                Hcanva.SetActive(false);
            }
        }
        else
        {
            OandHcanva.SetActive(false);
            CandHcanva.SetActive(false);
            HandNAcanva.SetActive(false);
            HandCl_Canva.SetActive(false);
            SandHcanva.SetActive(false);
        }

        if (CshowUp)
        {
            if (OshowUp)
            {
                CandOcanva.SetActive(true);
                Ccanva.SetActive(false);
                Ocanva.SetActive(false);
            }
            else if (NaShowUp)
            {
                CandNa_canva.SetActive(true);
                Ccanva.SetActive(false);
                Nacanva.SetActive(false);
            }
        }
        else
        {
            CandOcanva.SetActive(false);
            CandNa_canva.SetActive(false);
        }

    }

    private void GetScriptBool()
    {
        HshowUp = gameObject.GetComponent<HcheckinView>().HshowUp;
        OshowUp = gameObject.GetComponent<OcheckinView>().OshowUp;
        CshowUp = gameObject.GetComponent<CcheckinView>().CshowUp;
        SshowUp = gameObject.GetComponent<S_check>().SshowUp;
        NaShowUp = gameObject.GetComponent<NacheckinView>().NashowUp;
    }
}
