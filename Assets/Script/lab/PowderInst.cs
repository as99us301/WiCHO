using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowderInst : MonoBehaviour
{
    public GameObject BaCl2, CaCO3, CuSO4, H3BO3, KCl, LiCl, NaCl;
    public GameObject instpos;
    public GameObject patentsPrefeb;

    public void BaCl2Click() 
    {
        CleanCloneAndDown();
        GameObject BaCl = Instantiate(BaCl2, instpos.transform.position, instpos.transform.rotation);
        BaCl.transform.parent = patentsPrefeb.transform;
    }
    public void CaCO3Click()
    {
        CleanCloneAndDown();
        GameObject CaCO = Instantiate(CaCO3, instpos.transform.position, instpos.transform.rotation);
        CaCO.transform.parent = patentsPrefeb.transform;
    }
    public void CuSO4Click()
    {
        CleanCloneAndDown();
        GameObject CuSO = Instantiate(CuSO4, instpos.transform.position, instpos.transform.rotation);
        CuSO.transform.parent = patentsPrefeb.transform;
    }
    public void H3BO3Click()
    {
        CleanCloneAndDown();
        GameObject h3bo = Instantiate(H3BO3, instpos.transform.position, instpos.transform.rotation);
        h3bo.transform.parent = patentsPrefeb.transform;
    }
    public void KClClick()
    {
        CleanCloneAndDown();
        GameObject kcl = Instantiate(KCl, instpos.transform.position, instpos.transform.rotation);
        kcl.transform.parent = patentsPrefeb.transform;
    }
    public void LiClClick()
    {
        CleanCloneAndDown();
        GameObject licl = Instantiate(LiCl, instpos.transform.position, instpos.transform.rotation);
        licl.transform.parent = patentsPrefeb.transform;
    }
    public void NaClClick()
    {
        CleanCloneAndDown();
        GameObject nacl = Instantiate(NaCl, instpos.transform.position, instpos.transform.rotation);
        nacl.transform.parent = patentsPrefeb.transform;
    }


    private void CleanCloneAndDown() {
        GameObject.Find("UpButton").GetComponent<OpenPanel>().DownMenu();
        Destroy(GameObject.Find("spoon+BaCl2(Clone)"));
        Destroy(GameObject.Find("spoon+CaCO3(Clone)"));
        Destroy(GameObject.Find("spoon+CuSO4(Clone)"));
        Destroy(GameObject.Find("spoon+H3BO3(Clone)"));
        Destroy(GameObject.Find("spoon+KCl(Clone)"));
        Destroy(GameObject.Find("spoon+LiCl(Clone)"));
        Destroy(GameObject.Find("spoon+NaCl(Clone)"));
    }
}
