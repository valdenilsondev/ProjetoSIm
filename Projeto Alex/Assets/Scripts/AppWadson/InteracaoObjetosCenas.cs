using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteracaoObjetosCenas : MonoBehaviour
{

    private bool isVerificarToque;
    public GameObject baseBracoRobotico;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isVerificarToque)
        {
            if (Input.GetButton("Fire1"))
            {

                baseBracoRobotico.gameObject.transform.Rotate(new Vector3(0, 1, 0));


            }
        }
       
    }

    private void OnMouseDown()
    {
        isVerificarToque = true;
    }

    private void OnMouseExit()
    {
        isVerificarToque = false;
    }
}
