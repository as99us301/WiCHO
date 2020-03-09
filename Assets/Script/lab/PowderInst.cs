using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowderInst : MonoBehaviour
{
    public GameObject BaCl2, CaCO3, CuSO4, H3BO3, KCl, LiCl, NaCl;
    public GameObject instpos;

    public void BaCl2Click() 
    {
        CleanCloneAndDown();
        Instantiate(BaCl2, instpos.transform.position, instpos.transform.rotation);
    }
    public void CaCO3Click()
    {
        CleanCloneAndDown();
        Instantiate(CaCO3, instpos.transform.position, instpos.transform.rotation);
    }
    public void CuSO4Click()
    {
        CleanCloneAndDown();
        Instantiate(CuSO4, instpos.transform.position, instpos.transform.rotation);
    }
    public void H3BO3Click()
    {
        CleanCloneAndDown();
        Instantiate(H3BO3, instpos.transform.position, instpos.transform.rotation);
    }
    public void KClClick()
    {
        CleanCloneAndDown();
        Instantiate(KCl, instpos.transform.position, instpos.transform.rotation);
    }
    public void LiClClick()
    {
        CleanCloneAndDown();
        Instantiate(LiCl, instpos.transform.position, instpos.transform.rotation);
    }
    public void NaClClick()
    {
        CleanCloneAndDown();
        Instantiate(NaCl, instpos.transform.position, instpos.transform.rotation);
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
