using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementButton : MonoBehaviour
{
    public GameObject pos;
    public GameObject patentsPrefeb;
    public Text ElementnameEng; //英文
    public Text ElementnameZh; //中文
    public Text AtomicNumber; //原子序
    public Text AtomicMass; //原子量
    public string[,] Ballarray = new string[,] {{"1","H","氫","1"},{"2","He","氦","4"},
        {"3","Li","鋰","7"},{"4","Be","鈹","9"},{"5","B","硼","11"},{"6","C","碳","12"},
        {"7","N","氮","14"},{"8","O","氧","16"},{"9","F","氟","19"},{"10","Ne","氖","20"},
        {"11","Na","鈉","23"},{"12","Mg","鎂","24"},{"13","Al","鋁","27"},{"14","Si","矽","26"},
        {"15","P","磷","31"},{"16","S","硫","32"},{"17","Cl","氯","35"},{"18","Ar","氬","40"},
        {"19","K","鉀","39"},{"20","Ca","鈣","40"},{"21","Sc","鈧","45"},{"22","Ti","鈦","48"},
        {"23","V","釩","51"},{"24","Cr","鉻","52"},{"25","Mn","錳","55"},{"26","Fe","鐵","56"},
        {"27","Co","鈷","59"},{"28","Ni","鎳","58"},{"29","Cu","銅","63"},{"30","Zn","鋅","64"},
        {"31","Ga","鎵","69"},{"32","Ge","鍺","74"},{"33","As","砷","75"},{"34","Se","硒","80"},
        {"35","Br","溴","79"},{"36","Kr","氪","84"},{"37","Rb","銣","85"},{"38","Sr","鍶","88"},
        {"39","Y","釔","89"},{"40","Zr","鋯","90"},{"41","Nb","鈮","93"},{"42","Mo","鉬","98"},
        {"43","Tc","鎝","99"},{"44","Ru","釕","102"},{"45","Rh","銠","103"},{"46","Pd","鈀","106"},
        {"47","Ag","銀","107"},{"48","Cd","鎘","114"},{"49","In","銦","115"},{"50","Sn","錫","118"},
        {"51","Sb","銻","121"},{"52","Te","碲","130"},{"53","I","碘","127"},{"54","Xe","氙","132"},
        {"55","Cs","銫","133"},{"56","Ba","鋇","138"},{"71","Lu","鎦","175"},{"72","Hf","鉿","178"},
        {"73","Ta","鉭","181"},{"74","W","鎢","184"},{"75","Re","錸","187"},{"76","Os","鋨","192"},
        {"77","Ir","銥","193"},{"78","Pt","鉑","195"},{"79","Au","金","197"},{"80","Hg","汞","202"},
        {"81","Tl","鉈","205"},{"82","Pb","鉛","208"},{"83","Bi","鉍","209"},{"84","Po","釙","210"},
        {"85","At","砈","210"},{"86","Rn","氡","222"},{"87","Fr","鍅","223"},{"88","Ra","鐳","226"},
        {"103","Lr","鐒","262"},{"104","Rf","鑪","261"},{"105","Db","𨧀","262"},{"106","Sg","𨭎","266"},
        {"107","Bh","𨨏","264"},{"108","Hs","𨭆","277"},{"109","Mt","䥑","268"}};
    public GameObject[] ElementBalls;
    public GameObject eleImage;
    public GameObject[] introdImage;
    public int Typetextsize = 90;
    public int Numtextsize = 80;
    public GameObject testmanager;

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

    public void closeimage() 
    {
        for (int i = 0; i <= introdImage.Length - 1; i++) 
        {
            introdImage[i].SetActive(false);
        }
    }

    public void newball(int number)
    {
        cleanObj();
        closeimage();
        eleImage.SetActive(true);
        GameObject obj = Instantiate(ElementBalls[number], pos.transform.position, pos.transform.rotation);
        obj.transform.parent = patentsPrefeb.transform;
        ChangeTextSize();
        AtomicNumber.text = Ballarray[number, 0];
        ElementnameEng.text = Ballarray[number, 1];
        ElementnameZh.text = Ballarray[number, 2];
        AtomicMass.text = Ballarray[number, 3];
        testmanager.GetComponent<NumberBridge>().testnum = number;
    }

    public void ChangeTextSize() 
    {
        ElementnameEng.fontSize = Typetextsize;
        ElementnameZh.fontSize = Typetextsize;
        AtomicMass.fontSize = Numtextsize;
        AtomicNumber.fontSize = Numtextsize;
    }


    public void thing1Click() {
        closeimage();
        eleImage.SetActive(true);
    }

    public void HClick()
    {
        newball(0);
    }
    public void HeClick()
    {
        newball(1);
    }
    public void LiClick()
    {
        newball(2);
    }
    public void BeClick()
    {
        newball(3);
    }
    public void BClick()
    {
        newball(4);
    }
    public void CClick()
    {
        newball(5);
    }
    public void NClick()
    {
        newball(6);
    }
    public void OClick()
    {
        newball(7);
    }
    public void FClick()
    {
        newball(8);
    }
    public void NeClick()
    {
        newball(9);
    }
    public void NaClick()
    {
        newball(10);
    }
    public void MgClick()
    {
        newball(11);
    }
    public void AlClick()
    {
        newball(12);
    }
    public void SiClick()
    {
        newball(13);
    }
    public void PClick()
    {
        newball(14);
    }
    public void SClick()
    {
        newball(15);
    }
    public void ClClick()
    {
        newball(16);
    }
    public void ArClick()
    {
        newball(17);
    }
    public void KClick()
    {
        newball(18);
    }
    public void CaClick()
    {
        newball(19);
    }
    public void ScClick()
    {
        newball(20);
    }
    public void TiClick()
    {
        newball(21);
    }
    public void VClick()
    {
        newball(22);
    }
    public void CrClick()
    {
        newball(23);
    }
    public void MnClick()
    {
        newball(24);
    }
    public void FeClick()
    {
        newball(25);
    }
    public void CoClick()
    {
        newball(26);
    }
    public void NiClick()
    {
        newball(27);
    }
    public void CuClick()
    {
        newball(28);
    }
    public void ZnClick()
    {
        newball(29);
    }
    public void GaClick()
    {
        newball(30);
    }
    public void GeClick()
    {
        newball(31);
    }
    public void AsClick()
    {
        newball(32);
    }
    public void SeClick()
    {
        newball(33);
    }
    public void BrClick()
    {
        newball(34);
    }
    public void KrClick()
    {
        newball(35);
    }
    public void RbClick()
    {
        newball(36);
    }
    public void SrClick()
    {
        newball(37);
    }
    public void YClick()
    {
        newball(38);
    }
    public void ZrClick()
    {
        newball(39);
    }
    public void NbClick()
    {
        newball(40);
    }
    public void MoClick()
    {
        newball(41);
    }
    public void TcClick()
    {
        newball(42);
    }
    public void RuClick()
    {
        newball(43);
    }
    public void RhClick()
    {
        newball(44);
    }
    public void PdClick()
    {
        newball(45);
    }
    public void AgClick()
    {
        newball(46);
    }
    public void CdClick()
    {
        newball(47);
    }
    public void InClick()
    {
        newball(48);
    }
    public void SnClick()
    {
        newball(49);
    }
    public void SbClick()
    {
        newball(50);
    }
    public void TeClick()
    {
        newball(51);
    }
    public void IClick()
    {
        newball(52);
    }
    public void XeClick()
    {
        newball(53);
    }
    public void CsClick()
    {
        newball(54);
    }
    public void BaClick()
    {
        newball(55);
    }
    public void LuClick()
    {
        newball(56);
    }
    public void HfClick()
    {
        newball(57);
    }
    public void TaClick()
    {
        newball(58);
    }
    public void WClick()
    {
        newball(59);
    }
    public void ReClick()
    {
        newball(60);
    }
    public void OsClick()
    {
        newball(61);
    }
    public void IrClick()
    {
        newball(62);
    }
    public void PtClick()
    {
        newball(63);
    }
    public void AuClick()
    {
        newball(64);
    }
    public void HgClick()
    {
        newball(65);
    }
    public void TlClick()
    {
        newball(66);
    }
    public void PbClick()
    {
        newball(67);
    }
    public void BiClick()
    {
        newball(68);
    }
    public void PoClick()
    {
        newball(69);
    }
    public void AtClick()
    {
        newball(70);
    }
    public void RnClick()
    {
        newball(71);
    }
    public void FrClick()
    {
        newball(72);
    }
    public void RaClick()
    {
        newball(73);
    }
    public void LrClick()
    {
        newball(74);
    }
    public void RfClick()
    {
        newball(75);
    }
    public void DbClick()
    {
        newball(76);
    }
    public void SgClick()
    {
        newball(77);
    }
    public void BhClick()
    {
        newball(78);
    }
    public void HsClick()
    {
        newball(79);
    }
    public void MtClick()
    {
        newball(80);
    }
}
