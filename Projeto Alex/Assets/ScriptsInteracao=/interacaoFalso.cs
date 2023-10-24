using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacaoFalso : MonoBehaviour
{
    bool isverificar;
    bool isPainel;
    public GameObject painelErro;


   


    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (isverificar)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                isPainel = !isPainel;
            }
           
        }
        if (isPainel)
        {
            painelErro.SetActive(true);
            isPainel = false;
          
        }
    }

    private void OnMouseDown()
    {
        isverificar = true;
    }
    private void OnMouseExit()
    {
        isverificar = false;
    }
}
