using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacaoLixo : MonoBehaviour
{
    private bool isVerificacao;
    private bool isPainel;
    public bool isAperteiBotao;
    public GameObject indicadorSelecao;
    public GameObject[] lixeiras;
    public GameObject[] lixeiras1;
    public GameObject[] lixeiras2;

    public GameObject obj;
   
  

 

    void Start()
    {
        indicadorSelecao.SetActive(false);

        for(int i=0; i < 6; i++)
        {
            lixeiras[i].SetActive(false);
        }
        obj = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (isVerificacao == true)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                isPainel = !isPainel;
            }
            for (int i = 0; i < 6; i++)
            {
                lixeiras1[i].SetActive(false);
                lixeiras2[i].SetActive(false);
            }

        }
      
        if (isPainel && isAperteiBotao == false)
        {
            indicadorSelecao.SetActive(true);
            isPainel = false;
            isAperteiBotao = true;

         
            for (int i = 0; i < 6; i++)
            {
                lixeiras[i].SetActive(true);
            }

        }
    }

    private void OnMouseDown()
    {
        isVerificacao = true;
    }

    private void OnMouseExit()
    {
        isVerificacao = false;
    }
}
