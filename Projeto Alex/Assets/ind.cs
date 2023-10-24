using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ind : MonoBehaviour
{
    public int numeroLixo;
    private bool isVerificar;
    private bool isPainel;
    private interacaoLixo _int;
    private bool isPressinou;
    private bool concluiu;
    public string nome;
  
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isVerificar == true)
        {
            if (Input.GetButtonDown("Fire1"))
            {

                isPainel = !isPainel;

            }
        }

        if(isPainel == true && isPressinou == false)
        {
            
            isPressinou = true;
            numeroLixo = 2;
            Debug.Log(numeroLixo);
            nome = gameObject.name;
            Debug.Log(nome);
        }

     

    }

    private void OnMouseEnter()
    {
        isVerificar = true;
    }

    private void OnMouseExit()
    {
        isVerificar = false;
    }
}
