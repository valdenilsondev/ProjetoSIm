using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FecharPainel : MonoBehaviour
{
    public GameObject painelAcertou;
    public GameObject painelErrou;


    private void Start()
    {
    
     
    }
    public void fecharPeinalAcertou()
    {
 
        painelAcertou.SetActive(false);
     

    }
    public void fecharPainelErrou()
    {
        painelErrou.SetActive(false);
    }


}
