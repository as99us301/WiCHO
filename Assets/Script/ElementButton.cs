using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementButton : MonoBehaviour
{
    public GameObject pos;
    public GameObject H, He;
    public GameObject Li, Be, B, C, N, O, F, Ne;
    public GameObject Na, Mg, Al, Si, P, S, Cl, Ar;
    public GameObject K, Ca, Sc, Ti, V, Cr, Mn, Fe, Co, Ni, Cu, Zn, Ga, Ge, As, Se, Br, Kr;
    public GameObject Rb, Sr, Y, Zr, Nb, Mo, Tc, Ru, Rh, Pd, Ag, Cd, In, Sn, Sb, Te, I, Xe;
    public GameObject Cs, Ba, Lu, Hf, Ta, W, Re, Os, Ir, Pt, Au, Hg, Tl, Pb, Bi, Po, At, Rn;
    public GameObject Fr, Ra, Lr, Rf, Db, Sg, Bh, Hs, Mt;
    public GameObject patentsPrefeb;

    public void cleanObj() 
    {
        Destroy(GameObject.Find("H_new(Clone)"));
        Destroy(GameObject.Find("He_new(Clone)"));
        Destroy(GameObject.Find("Li_new(Clone)"));
        Destroy(GameObject.Find("Be_new(Clone)"));
        Destroy(GameObject.Find("B_new(Clone)"));
        Destroy(GameObject.Find("C_new(Clone)"));
        Destroy(GameObject.Find("N_new(Clone)"));
        Destroy(GameObject.Find("O_new(Clone)"));
        Destroy(GameObject.Find("F_new(Clone)"));
        Destroy(GameObject.Find("Ne_new(Clone)"));
        Destroy(GameObject.Find("Na_new(Clone)"));
        Destroy(GameObject.Find("Mg_new(Clone)"));
        Destroy(GameObject.Find("Al_new(Clone)"));
        Destroy(GameObject.Find("Si_new(Clone)"));
        Destroy(GameObject.Find("P_new(Clone)"));
        Destroy(GameObject.Find("S_new(Clone)"));
        Destroy(GameObject.Find("Cl_new(Clone)"));
        Destroy(GameObject.Find("Ar_new(Clone)"));
        Destroy(GameObject.Find("K_new(Clone)"));
        Destroy(GameObject.Find("Ca_new(Clone)"));
        Destroy(GameObject.Find("Sc_new(Clone)"));
        Destroy(GameObject.Find("Ti_new(Clone)"));
        Destroy(GameObject.Find("V_new(Clone)"));
        Destroy(GameObject.Find("Cr_new(Clone)"));
        Destroy(GameObject.Find("Mn_new(Clone)"));
        Destroy(GameObject.Find("Fe_new(Clone)"));
        Destroy(GameObject.Find("Co_new(Clone)"));
        Destroy(GameObject.Find("Ni_new(Clone)"));
        Destroy(GameObject.Find("Cu_new(Clone)"));
        Destroy(GameObject.Find("Zn_new(Clone)"));
        Destroy(GameObject.Find("Ga_new(Clone)"));
        Destroy(GameObject.Find("Ge_new(Clone)"));
        Destroy(GameObject.Find("As_new(Clone)"));
        Destroy(GameObject.Find("Se_new(Clone)"));
        Destroy(GameObject.Find("Br_new(Clone)"));
        Destroy(GameObject.Find("Kr_new(Clone)"));
        Destroy(GameObject.Find("Rb_new(Clone)"));
        Destroy(GameObject.Find("Y_new(Clone)"));
        Destroy(GameObject.Find("Zr_new(Clone)"));
        Destroy(GameObject.Find("Nb_new(Clone)"));
        Destroy(GameObject.Find("Mo_new(Clone)"));
        Destroy(GameObject.Find("Tc_new(Clone)"));
        Destroy(GameObject.Find("Ru_new(Clone)"));
        Destroy(GameObject.Find("Rh_new(Clone)"));
        Destroy(GameObject.Find("Pd_new(Clone)"));
        Destroy(GameObject.Find("Ag_new(Clone)"));
        Destroy(GameObject.Find("Cd_new(Clone)"));
        Destroy(GameObject.Find("In_new(Clone)"));
        Destroy(GameObject.Find("Sn_new(Clone)"));
        Destroy(GameObject.Find("Sb_new(Clone)"));
        Destroy(GameObject.Find("Te_new(Clone)"));
        Destroy(GameObject.Find("I_new(Clone)"));
        Destroy(GameObject.Find("Xe_new(Clone)"));
        Destroy(GameObject.Find("Cs_new(Clone)"));
        Destroy(GameObject.Find("Ba_new(Clone)"));
        Destroy(GameObject.Find("Lu_new(Clone)"));
        Destroy(GameObject.Find("Hf_new(Clone)"));
        Destroy(GameObject.Find("Ta_new(Clone)"));
        Destroy(GameObject.Find("W_new(Clone)"));
        Destroy(GameObject.Find("Re_new(Clone)"));
        Destroy(GameObject.Find("Os_new(Clone)"));
        Destroy(GameObject.Find("Ir_new(Clone)"));
        Destroy(GameObject.Find("Pt_new(Clone)"));
        Destroy(GameObject.Find("Au_new(Clone)"));
        Destroy(GameObject.Find("Hg_new(Clone)"));
        Destroy(GameObject.Find("Tl_new(Clone)"));
        Destroy(GameObject.Find("Pb_new(Clone)"));
        Destroy(GameObject.Find("Bi_new(Clone)"));
        Destroy(GameObject.Find("Po_new(Clone)"));
        Destroy(GameObject.Find("At_new(Clone)"));
        Destroy(GameObject.Find("Rn_new(Clone)"));
        Destroy(GameObject.Find("Ra_new(Clone)"));
        Destroy(GameObject.Find("Lr_new(Clone)"));
        Destroy(GameObject.Find("Rf_new(Clone)"));
        Destroy(GameObject.Find("Db_new(Clone)"));
        Destroy(GameObject.Find("Sg_new(Clone)"));
        Destroy(GameObject.Find("Bh_new(Clone)"));
        Destroy(GameObject.Find("Hs_new(Clone)"));
        Destroy(GameObject.Find("Mt_new(Clone)"));
        Destroy(GameObject.Find("Fr_new(Clone)"));
        Destroy(GameObject.Find("Sr_new(Clone)"));

    }
    public void HClick()
    {
        cleanObj();
        GameObject obj = Instantiate(H, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void HeClick()
    {
        cleanObj();
        GameObject obj = Instantiate(He, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void LiClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Li, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void BeClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Be, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void BClick()
    {
        cleanObj();
        GameObject obj = Instantiate(B, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void CClick()
    {
        cleanObj();
        GameObject obj = Instantiate(C, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void NClick()
    {
        cleanObj();
        GameObject obj = Instantiate(N, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void OClick()
    {
        cleanObj();
        GameObject obj = Instantiate(O, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void FClick()
    {
        cleanObj();
        GameObject obj = Instantiate(F, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void NeClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Ne, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void NaClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Na, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void MgClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Mg, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void AlClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Al, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void SiClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Si, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void PClick()
    {
        cleanObj();
        GameObject obj = Instantiate(P, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void SClick()
    {
        cleanObj();
        GameObject obj = Instantiate(S, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void ClClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Cl, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void ArClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Ar, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void KClick()
    {
        cleanObj();
        GameObject obj = Instantiate(K, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void CaClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Ca, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void ScClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Sc, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void TiClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Ti, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void VClick()
    {
        cleanObj();
        GameObject obj = Instantiate(V, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void CrClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Cr, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void MnClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Mn, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void FeClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Fe, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void CoClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Co, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void NiClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Ni, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void CuClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Cu, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void ZnClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Zn, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void GaClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Ga, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void GeClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Ge, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void AsClick()
    {
        cleanObj();
        GameObject obj = Instantiate(As, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void SeClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Se, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void BrClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Br, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void KrClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Kr, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void RbClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Rb, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void SrClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Sr, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void YClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Y, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void ZrClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Zr, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void NbClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Nb, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void MoClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Mo, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void TcClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Tc, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void RuClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Ru, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void RhClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Rh, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void PdClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Pd, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void AgClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Ag, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void CdClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Cd, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void InClick()
    {
        cleanObj();
        GameObject obj = Instantiate(In, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void SnClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Sn, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void SbClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Sb, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void TeClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Te, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void IClick()
    {
        cleanObj();
        GameObject obj = Instantiate(I, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void XeClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Xe, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void CsClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Cs, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void BaClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Ba, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void LuClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Lu, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void HfClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Hf, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void TaClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Ta, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void WClick()
    {
        cleanObj();
        GameObject obj = Instantiate(W, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void ReClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Re, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void OsClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Os, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void IrClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Ir, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void PtClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Pt, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void AuClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Au, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void HgClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Hg, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void TlClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Tl, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void PbClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Pb, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void BiClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Bi, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void PoClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Po, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void AtClick()
    {
        cleanObj();
        GameObject obj = Instantiate(At, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void RnClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Rn, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void FrClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Fr, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void RaClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Ra, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void LrClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Lr, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void RfClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Rf, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void DbClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Db, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void SgClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Sg, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void BhClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Bh, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void HsClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Hs, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
    public void MtClick()
    {
        cleanObj();
        GameObject obj = Instantiate(Mt, pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
    }
}
