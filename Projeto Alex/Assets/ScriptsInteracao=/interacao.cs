using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacao : MonoBehaviour
{
    bool isverificar;
    bool isPaine11;
    public GameObject painelAcerto;
    public GameObject painelErro;
    public GameObject lixo;


    void Start()
    {
       
        isPaine11 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isverificar)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                isPaine11 = true;
            }
           
        }
        if (isPaine11)
        {
            painelAcerto.SetActive(true);
            isPaine11 = false;
            Destroy(lixo.gameObject);
                    
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
