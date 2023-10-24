using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacao1 : MonoBehaviour
{
    bool isverificar;
    bool isPainel;
    public GameObject painelAcerto;
    public GameObject painelErro;

    public GameObject platico;
   


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
            painelAcerto.SetActive(true);
            isPainel = false;
            Destroy(platico.gameObject);
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
